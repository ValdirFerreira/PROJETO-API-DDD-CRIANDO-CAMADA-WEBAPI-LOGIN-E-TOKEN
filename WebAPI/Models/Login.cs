using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Login
    {
        public string email { get; set; }
        public string senha { get; set; }
        public int idade { get; set; }
        public string celular { get; set; }
    }
}
