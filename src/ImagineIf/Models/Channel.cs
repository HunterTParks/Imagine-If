using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagineIf.Models
{
    public class Channel
    {
        public int id { get; set; }
        public int type { get; set; }
        public int guild_id { get; set; }
        public int Position { get; set; }
        public List<Overwrite> Permission_Overwrites { get; set; }
        public string name { get; set; }
        public string Topic { get; set; }
        public int Bitrate { get; set; }
        public int User_Limit { get; set; }
        public List<ApplicationUser> Recipients { get; set; }
        public string Icon { get; set; }
        public int Owner_Id { get; set; }
        public int Application_Id { get; set; }

        public static List<DiscordMessage> GetMessages()
        {
            
        }
    }
}
