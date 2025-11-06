using Practica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Servicios
{
    internal class ReportePDF : IReport
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generando reporte en PDF...");            
        }
    }
}
