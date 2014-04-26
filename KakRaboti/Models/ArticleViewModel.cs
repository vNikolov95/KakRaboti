using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using KakRaboti.KakRabotiService;

namespace KakRaboti.Models
{
    public class CreateArticleViewModel
    {
        [Required(ErrorMessage = "Полето е задължително")]
        [Display(Name="Заглавие")]
        [StringLength(50)]
        public string Title { get; set; }

        [Required(ErrorMessage="Полето е задължително")]
        [Display(Name="Съдържание")]
        [StringLength(1000000000,MinimumLength=800,ErrorMessage="Полето трябва да е поне 800 символа")]
        public string Text { get; set; }

        [Required(ErrorMessage = "Полето е задължително")]
        [Display(Name = "Категория")]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Полето е задължително")]
        [Display(Name = "Кратко описание")]
        [StringLength(400,ErrorMessage="Полето трябва да е с дължина между 100 и 400 символа",MinimumLength=100)]
        public string Description { get; set; }

        public int Id { get; set; }
    }

}