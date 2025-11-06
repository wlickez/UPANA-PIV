using Practica.Interfaces;

namespace Practica.Servicios
{
    internal class ReporteExcel : IReport
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generando reporte en Excel...");
        }
    }
}
