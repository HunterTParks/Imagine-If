using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagineIf.Models
{
    public class User
    {
        public int id { get; set; }
        public string Username { get; set; }
        public string Discriminator { get; set; }
        public string Avatar { get; set; }
        public bool Bot { get; set; }
        public bool Mfa_Enabled { get; set; }
        public bool Verified { get; set; }
        public string Email { get; set; }
    }
}
