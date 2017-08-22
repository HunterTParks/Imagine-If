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
        public string name { get; set; }
    }
}
