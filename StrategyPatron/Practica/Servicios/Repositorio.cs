using Practica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Servicios
{
    internal class Repositorio : IRepository
    {
        public void SaveReport(string path)
        {
            Console.WriteLine("Guardando repositorio en: " + path);
        }
    }
}
