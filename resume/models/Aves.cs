using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resume.models
{
    internal class Aves : Animal
    {
        public string Nombre { get; set; }
        protected int Edad { get; set; }
        public string NombreDueno { get; set; }

        public bool SiVuela { get; set; }

       
    }
}
