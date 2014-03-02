using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KakRaboti.Models
{
    public class CategoryViewModel
    {
        [Required(ErrorMessage = "Полето е задължително")]
        [Display(Name = "Име")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Полето е задължително")]
        [Display(Name = "Описание")]
        [StringLength(400)]
        public string Description { get; set; }

        public int ID { get; set; }
    }
}