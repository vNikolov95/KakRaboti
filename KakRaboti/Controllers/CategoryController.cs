using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KakRaboti.Models;
using KakRaboti.KakRabotiService;

namespace KakRaboti.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class CategoryController : Controller
    {
        KakRabotiServiceClient channel = new KakRabotiServiceClient();

        // GET: /Category/Category/5
        [AllowAnonymous]
        public ActionResult Category(int id)
        {
            var articles = channel.GetAllArticles().Where(x => x.CategoryID == id).ToList();
            var category = channel.GetCategoryById(id);
            ViewBag.Title = category.Name;
            return View(articles);
        }

        // GET: /Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Category/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,Description")] CategoryViewModel category)
        {
            if (ModelState.IsValid)
            {
                KakRabotiService.Category newCategory = new Category()
                {
                    Description = category.Description,
                    Name = category.Name,
                };
                channel.CreateCategory(newCategory);
                return RedirectToAction("Index","Home");
            }
            return View(category);
        }

        // GET: /Category/Edit/5
        public ActionResult Edit(int id)
        {
            Category category = channel.GetCategoryById(id);
            CategoryViewModel catView = new CategoryViewModel()
            {
                Name = category.Name,
                Description = category.Description,
                ID = category.ID,
            };
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(catView);
        }

        // POST: /Category/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description")] CategoryViewModel category,string returnUrl)
        {
            if (ModelState.IsValid)
            {
                KakRabotiService.Category editedCategory = channel.GetCategoryById(category.ID);

                editedCategory.ID = category.ID;
                editedCategory.Name = category.Name;
                editedCategory.Description = category.Description;

                channel.EditCategory(editedCategory);
                return RedirectToLocal(returnUrl);
            }
            return View(category);
        }

        // POST: /Category/Delete/5
        public ActionResult Delete(int id)
        {
            channel.DeleteCategory(id);
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            //if (disposing)
            //{
            //    db.Dispose();
            //}
            //base.Dispose(disposing);
        }
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
