﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhotoAlbum.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        [Display(Name = "User Id")]
        public string UserName { get; set; }
        public DateTime Created { get; set; }
        public List<Photo> Photos { get; set; }
    }
}