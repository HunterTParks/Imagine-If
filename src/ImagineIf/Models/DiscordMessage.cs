using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discord.Commands;

namespace ImagineIf.Models
{
    public class DiscordMessage
    {
        public int Id { get; set; }
        public int Channel_id { get; set; }
        public ApplicationUser Author { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
        public DateTime Editted_TimeStamp { get; set; }
        public bool TTS { get; set; }
        public bool Mention_Everyone { get; set; }
        public List<ApplicationUser> Mentions { get; set; }
        public List<Attachment> attachments { get; set; }
        public List<Embed> Embeds { get; set; }
        public bool Pinned { get; set; }
        public int Type { get; set; }
    }
}
