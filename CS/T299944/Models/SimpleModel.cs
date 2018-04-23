using DevExpress.Web;
using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace T299944.Models
{
    public class SimpleModel
    {
        [Display(Name = "Name:")]
        [Required(ErrorMessage = "Name is required")]
        [RegularExpression(@"(\S)+", ErrorMessage = "White space is not allowed")]
        [Remote("CheckUserName", "Home", ErrorMessage = "Name cannot be 'admin'")]
        public string Name { get; set; }

        [Display(Name = "Email:")]
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*", ErrorMessage = "Email is invalid")]
        public string Email { get; set; }

        [Display(Name = "Phone:")]
        [Mask("+1 (999) 000-0000", IncludeLiterals = MaskIncludeLiteralsMode.DecimalSymbol, PromptChar = '_', ErrorMessage = "Phone number is invalid")]
        public string Phone { get; set; }

        [Display(Name = "Age:")]
        [Required(ErrorMessage = "Age is required")]
        [Range(18, 100, ErrorMessage = "Must be between 18 and 100")]
        public int? Age { get; set; }
    }
   
}