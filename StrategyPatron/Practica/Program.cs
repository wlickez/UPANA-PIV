using Practica.Interfaces;
using Practica.Servicios;

namespace Practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IReport report = new ReporteExcel();

            report.GenerateReport();

            IRepository repository = new Repositorio();
            repository.SaveReport("reporte.pdf");

            INotificar notificar = new Notificar();
            notificar.SendReportByEmail("correo@algo.com");
        }
    }
}
