using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoundCloud.Models
{
    public class Song
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string AlbumName { get; set; }
        public string FileName { get; set; }
    }
}