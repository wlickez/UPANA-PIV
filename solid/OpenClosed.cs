namespace Models
{
    public interface IGenerarReporte
    {
        void GenerarReporte();
    }


    public class GenerarReporteExcel : IGenerarReporte
    {
        public void GenerarReporte()
        {

        }
    }

    public class GenerarReportePDF : IGenerarReporte
    {
        public void GenerarReporte()
        {
            //generar re
        }
    }
}