using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagineIf.Models
{
    public class Attachment
    {
        public int Id { get; set; }
        public string Filename { get; set; }
        public int Size { get; set; }
        public string Url { get; set; }
        public string Proxy_url { get; set; }
        public int height { get; set; }
        public int width { get; set; }
    }
}
