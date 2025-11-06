using System.Xml.Serialization;

namespace StrategyPatron
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ImplementadorImpuesto implementador = new ImplementadorImpuesto();
            Console.WriteLine("Seleccione el impuesto:");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    implementador.DefinirEstrategia(new ImpuestoIva(0.15));
                    break;
                case 2:
                    implementador.DefinirEstrategia(new ImpuestoISR());
                    break;
                case 3:
                    implementador.DefinirEstrategia(new ImpuestoISCV());
                    break;
                default:
                    implementador.DefinirEstrategia(new SinImpuesto());
                    break;
            }

            double monto = 300000;

            double impuesto = implementador.CalcularImpuesto(monto);
            Console.WriteLine($"El impuesto del monto: {monto} es: {impuesto}");
        }
    }
}
