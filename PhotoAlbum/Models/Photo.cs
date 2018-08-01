using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhotoAlbum.Models
{
    public class Photo
    {
        public int Id { get; set; }
        [Display(Name = "File Name")]
        [Required]
        public string UserFileName { get; set; }
        public string SystemFileName { get; set; }
        [Display(Name = "Content Type")]
        public string FileType { get; set; }
        [Display(Name = "File Size")]
        public int FileSize { get; set; }
        public string FilePath { get; set; }
        [Display(Name = "User Id")]
        public string UserName { get; set; }
        public DateTime Created { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }
    }
}