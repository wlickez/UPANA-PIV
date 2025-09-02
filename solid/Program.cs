// See https://aka.ms/new-console-template for more information
using Models;
using Models2;

Console.WriteLine("Hello, World!");

// IGenerarReporte reporte = new GenerarReporteExcel();
// reporte.GenerarReporte();

GenerarReporteL generar = new GeneracionReportePDF_2();

generar.GeneraracionReporte();