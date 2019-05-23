using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BirthdayCardGenerator.Models
{
    public class BirthdayCard
    {
        [Required(ErrorMessage = "Please enter To")]
        [Display(Name = "To: ")]
        public string To { get; set; }

        [Required(ErrorMessage = "Please enter From")]
        [Display(Name = "From: ")]
        public string From { get; set; }

        [Required(ErrorMessage = "Please enter Message")]
        [Display(Name = "Message: ")]
        public string Message { get; set; }
    }
}