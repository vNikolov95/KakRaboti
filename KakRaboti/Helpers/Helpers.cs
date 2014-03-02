using KakRaboti.KakRabotiService;
using KakRaboti.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KakRaboti.Helpers
{
    public class Helpers
    {
        public static KakRabotiService.KakRabotiServiceClient channel = new KakRabotiServiceClient();
        public static ApplicationDbContext context = new ApplicationDbContext();

        public static IEnumerable<ApplicationUser> GetUsers()
        {
            return context.Users.ToList();
        }

        public static IEnumerable<IdentityRole> GetRoles()
        {
            return context.Roles.ToList();
        }

        public static IEnumerable<Category> GetCategories()
        {
            var categories = channel.GetAllCategories();
            return categories;
        }

        public static IEnumerable<Article> GetNotApprovedArticles()
        {
            var articles = channel.GetNotApprovedArticles();
            return articles;
        }

        public static IEnumerable<Article> GetNewestArticles()
        {
            var articles = channel.GetAllArticles().ToList().OrderByDescending(x => x.ID);
            return articles;
        }
        public static IEnumerable<Article> GetArticlesWithThumbs()
        {
            Random rnd = new Random();
            var articles = channel.GetAllArticles().ToList().OrderBy(x => rnd.Next()).Take(5);
            return articles;
        }
    }
}