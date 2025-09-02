using Api.Interfaces;

namespace Api.Serivces
{
    public class OperacionesServices : IOperaciones
    {
        public int Rest(int a, int b)
        {
           return a + b;
        }

        public int Suma(int a, int b)
        {
            return a - b;
        }
    }
}
