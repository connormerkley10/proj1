using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    public class Classs
    {
        [Required]
        [Display(Name = "Class Code")]
        public int Class_Code { get; set; }

        [Required]
        [Display(Name = "Class Title")]
        public string Class_Title { get; set; }

        [Required]
        [Display(Name = "Class Description")]
        public string Class_Description { get; set; }

    }
}