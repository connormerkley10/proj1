using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    public class Homework
    {
        [Required]
        [Display(Name = "Class Code")]
        public int Class_Code { get; set; }

        [Required]
        [Display(Name = "Homework Code")]
        public int Homework_Code { get; set; }

        [Required]
        [Display(Name = "Homework Description")]
        public string Homework_Desc { get; set; }

        [Required]
        [Display(Name = "Due Date")]
        public DateTime DueDate { get; set; }

    }
}