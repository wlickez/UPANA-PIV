using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraApp.Models
{
    public   class Usuario
    {
        public  string User { get; set; }
        public string Password { get; set; }
        public bool Recordarme { get; set; }

        public bool IsValid()
        {
            if (User == "admin" && Password == "12345")
                return true;

            return false;
        }
    }
}
