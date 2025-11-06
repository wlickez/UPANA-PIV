namespace StrategyPatron
{
    internal class ImpuestoIva : ICalcularImpuesto
    {
        private double _tasaImpuesto = 0.12;

        public ImpuestoIva()
        {

        }
        public ImpuestoIva(double tasaImpuesto)
        {
            _tasaImpuesto = tasaImpuesto;
        }
        public double CalcularImpuesto(double monto)
        {
            return monto * _tasaImpuesto;
        }
    }

    internal class ImpuestoISR : ICalcularImpuesto
    {
        public double CalcularImpuesto(double monto)
        {
            if (monto > 300000)
                return monto * 0.07;
            else 
                return monto * 0.05;    
        }
    }

    internal class ImpuestoISCV : ICalcularImpuesto
    {
        public double CalcularImpuesto(double monto)
        {
            return monto * 0.15;
        }
    }

    internal class SinImpuesto : ICalcularImpuesto
    {
        public double CalcularImpuesto(double monto)
        {
            return 0;
        }
    }
}
