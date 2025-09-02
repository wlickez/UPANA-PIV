namespace Models2
{
    //clase padre

    public class GenerarReporteL
    {
        public virtual void GeneraracionReporte()
        {

        }
    }

    public class GeneracionReporteExcel_2 : GenerarReporteL
    {
        public override void GeneraracionReporte()
        {
            Console.WriteLine("Generando Excel");
        }
    }

    public class GeneracionReportePDF_2 : GenerarReporteL
    {
        public override void GeneraracionReporte()
        {
            Console.WriteLine("Generando PDF");  
        }
    }
}