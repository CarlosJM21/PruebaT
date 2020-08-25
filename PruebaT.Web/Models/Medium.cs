using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaT.Web.Models
{
    public class Medium
    {
        public string group { get; set; }
        public string mediaType { get; set; }
        public string description { get; set; }
        public List<MediaItem> mediaItems { get; set; }
    }
}
