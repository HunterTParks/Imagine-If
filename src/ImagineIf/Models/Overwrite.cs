using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagineIf.Models
{
    public class Overwrite
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Allow { get; set; }
        public int Deny { get; set; }
    }
}
