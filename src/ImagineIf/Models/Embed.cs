using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagineIf.Models
{
    public class Embed
    {
        public string Title { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Color { get; set; }
        public EmbedFooter Footer { get; set; }
        public EmbedImage Image { get; set; }
        public EmbedThumbnail Thumbnail { get; set; }
        public EmbedVideo Video { get; set; }
        public EmbedProvider Provider { get; set; }
        public EmbedAuthor Author { get; set; }
        public List<EmbedField> Fields { get; set; }
    }
}
