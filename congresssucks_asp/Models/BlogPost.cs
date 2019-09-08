using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace congresssucks_asp.Models
{
    public class BlogPosts
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ShortPost { get; set; }
        [Required]
        public string Post { get; set; }
        [Required]
        public string Tags { get; set; }
        [Required]
        public DateTime Updated { get; set; }
    }
}