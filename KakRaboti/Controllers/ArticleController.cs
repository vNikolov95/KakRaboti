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
using System.Drawing;

namespace KakRaboti.Controllers
{
    [Authorize]
    public class ArticleController : Controller
    {
        private KakRabotiService.KakRabotiServiceClient channel = new KakRabotiService.KakRabotiServiceClient();

        private bool IsImage(HttpPostedFileBase file)
        {
            if (file.ContentType.Contains("image"))
            {
                return true;
            }

            string[] formats = new string[] { ".jpg", ".png", ".gif", ".jpeg" }; // add more if u like...

            // linq from Henrik Stenbæk
            return formats.Any(item => file.FileName.EndsWith(item, StringComparison.OrdinalIgnoreCase));
        }

        // GET: /Article/Read/5
        [AllowAnonymous]
        public ActionResult Read(int id)
        {


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
            byte[] data = null;
            if (file != null)
            {
                if (IsImage(file))
                {
                    Image image = new Bitmap(Image.FromStream(file.InputStream, true, true), new Size(169, 300));
                    Stream inputStream = file.InputStream;
                    MemoryStream stream = inputStream as MemoryStream;
                    stream = new MemoryStream();
                    inputStream.CopyTo(stream);
                    data = stream.ToArray();
                }
                else
                {
                    ViewData.ModelState.AddModelError("Thumbnail", "Изберете снимка в правилен формат");
                }
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
                    Thumbnail = "",
                    State = 1,
                    Author = User.Identity.GetUserName(),
                    Views = 0,
                };
                channel.CreateArticle(newArticle, data);
                return RedirectToAction("Index", "Home");
            }

            ViewBag.CategoryID = new SelectList(channel.GetAllCategories(), "ID", "Name", article.CategoryID);
            return View();
        }

        [AllowAnonymous]
        public ActionResult GetImage(string Id)
        {
            var image = channel.GetImage(Id);
            return File(image, "image/jpg");
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
