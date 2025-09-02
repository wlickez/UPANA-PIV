using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resume.models
{
    internal class Loro : Aves
    {

        public Loro() 
        { }
        public Loro(string nombre, string nombreDueno) 
        { 
            NombreDueno = nombreDueno;
            Nombre = nombre;
        }
        public void Hablar() 
        {
        }

        public void Hablar(string palabra)
        {

        }

        public void CalcularEdad(DateTime fechaNacimiento)
        {
            Edad = (DateTime.Now - fechaNacimiento).Days / 365;
        }

        public int DevolverEdad()
        {
            return Edad;
        }
    }
}
