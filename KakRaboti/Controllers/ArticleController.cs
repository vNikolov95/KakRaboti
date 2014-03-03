using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KakRaboti.Models;
using System.Text;
using System.IO;
using Microsoft.AspNet.Identity;
using KakRaboti.KakRabotiService;

namespace KakRaboti.Controllers
{
    [Authorize]
    public class ArticleController : Controller
    {
        private KakRabotiService.KakRabotiServiceClient channel = new KakRabotiService.KakRabotiServiceClient();

        // GET: /Article/Read/5
        [AllowAnonymous]
        public ActionResult Read(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Article article = channel.GetArticleById(id);

            if (article == null)
            {
                return HttpNotFound();
            }
            channel.UpdateArticleViews(id);
            article.Text = System.Web.HttpUtility.HtmlDecode(article.Text);
            ViewBag.Title = article.Title;
            return View(article);
        }

        // GET: /Article/Create
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(channel.GetAllCategories(), "ID", "Name");
            return View();
        }

        // POST: /Article/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Create([Bind(Include = "Title,Text,CategoryID,Description")] CreateArticleViewModel article, HttpPostedFileBase file)
        {
            Random _random = new Random(Environment.TickCount);
            string chars = "0123456789abcdefghijklmnopqrstuvwxyz";
            StringBuilder builder = new StringBuilder(25);
            for (int i = 0; i < 25; ++i)
                builder.Append(chars[_random.Next(chars.Length)]);
            string thumbnail = "";
            if (file != null)
            {
                string extension = Path.GetExtension(file.FileName);
                if (extension.ToLower() != ".jpg" && extension.ToLower() != ".png" && extension.ToLower() != ".gif")
                    return View(article);
                string fileName = builder.ToString() + extension;
                string path = Path.Combine(Server.MapPath("~/Thumbnails/"), fileName);
                file.SaveAs(path);
                thumbnail = "/Thumbnails/" + fileName;
            }
            else
            {
                ViewData.ModelState.AddModelError("Thumbnail", "Полето е задължително");
            }

            if (ModelState.IsValid)
            {
                Article newArticle = new Article()
                {
                    Title = article.Title,
                    Text = System.Web.HttpUtility.HtmlEncode(article.Text),
                    CategoryID = article.CategoryID,
                    DateAdded = DateTime.Now,
                    Description = article.Description,
                    Thumbnail = thumbnail,
                    State = 1,
                    Author = User.Identity.GetUserName(),
                    Views = 0,
                };
                channel.CreateArticle(newArticle);
                return RedirectToAction("Index","Home");
            }

            ViewBag.CategoryID = new SelectList(channel.GetAllCategories(), "ID", "Name", article.CategoryID);
            return View();
        }

        // GET: /Article/Edit/5
        [Authorize(Roles = "Administrator,Moderator")]
        public ActionResult Edit(int id, string returnUrl)
        {

            Article article = channel.GetArticleById(id);
            if (article == null)
            {
                return HttpNotFound();
            }

            ViewBag.CategoryID = new SelectList(channel.GetAllCategories(), "ID", "Name", article.CategoryID);
            ViewBag.ReturnUrl = returnUrl;
            
            CreateArticleViewModel articleToEdit = new CreateArticleViewModel()
            {
                Title = article.Title,
                CategoryID = article.CategoryID,
                Description = article.Description,
                Text = article.Text,
                Id = article.ID,
            };

            articleToEdit.Text = System.Web.HttpUtility.HtmlDecode(article.Text);
            return View(articleToEdit);
        }


        // POST: /Article/Edit/5
        [Authorize(Roles = "Administrator,Moderator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit([Bind(Include = "Id,Title,Text,CategoryID,Description")] CreateArticleViewModel article, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var editedArticle = channel.GetArticleById(article.Id);
                editedArticle.Text = System.Web.HttpUtility.HtmlEncode(article.Text);
                editedArticle.Title = article.Title;
                editedArticle.CategoryID = article.CategoryID;
                editedArticle.Description = article.Description;
                channel.EditArticle(editedArticle);
                return RedirectToLocal(returnUrl);
            }
            ViewBag.CategoryID = new SelectList(channel.GetAllCategories(), "ID", "Name", article.CategoryID);
            return View(article);
        }

        // GET: /Article/Delete/5
        [Authorize(Roles = "Administrator,Moderator")]
        public ActionResult Delete(int id)
        {
            channel.DeleteArticle(id);

            return RedirectToAction("Index", "Admin");
        }

        [Authorize(Roles = "Administrator,Moderator")]
        public ActionResult Approve(int id)
        {
            channel.ApproveArticle(id);
            return RedirectToAction("Index", "Admin");
        }

        [AllowAnonymous]
        public JsonResult GetComments(int articleId)
        {
            var comments = channel.GetComments(articleId);
            var Comments = from r in comments
                           select new
                           {
                               r.Author,
                               DateAdded = r.DateAdded.ToLongDateString(),
                               r.Text,
                               r.Id,
                           };

            return Json(Comments, JsonRequestBehavior.AllowGet);
        }

        [Authorize(Roles = "Administrator,Moderator")]
        public void DeleteComment(int id)
        {
            channel.DeleteComment(id);
        }

        [AllowAnonymous]
        public string AddComment(string author, string text, int articleId)
        {
            if (!String.IsNullOrWhiteSpace(author) && !String.IsNullOrWhiteSpace(text))
            {
                Comment newComment = new Comment()
                {
                    ArticleId = articleId,
                    Author = author,
                    DateAdded = DateTime.Now,
                    Text = text,
                };
                channel.CreateComment(newComment);
                return "";
            }
            else
            {
                return "Попълнете полетата";
            }
        }

        [AllowAnonymous]
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }

}
