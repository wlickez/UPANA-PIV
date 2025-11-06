namespace StrategyPatron
{
    internal class ImplementadorImpuesto
    {
        private ICalcularImpuesto _calcularImpuesto;

        public void DefinirEstrategia(ICalcularImpuesto calcularImpuesto)
        {
            _calcularImpuesto = calcularImpuesto;
        }

        public double CalcularImpuesto(double monto)
        {
            return _calcularImpuesto.CalcularImpuesto(monto);
        }
    }
}
