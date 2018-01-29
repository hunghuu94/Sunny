using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sunny.Model
{
    class User
    {
        public string userLogin { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public byte[] image { get; set; }
    }
}
