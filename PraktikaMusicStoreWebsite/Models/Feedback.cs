using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace PraktikaMusicStoreWebsite.Models
{
    public class Feedback
    {
        [Required()]
        public int FeedbackID { get; set; }

        public string Name { get; set; }

        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }

        [Required()]
        [Display(Name="Your Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}