using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace congresssucks_asp.Models
{
    public class BlogPosts
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [AllowHtml]
        public string ShortPost { get; set; }
        [Required]
        [AllowHtml]
        public string Post { get; set; }
        [Required]
        public string Tags { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Updated { get; set; }
    }
}