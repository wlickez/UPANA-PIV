namespace Models
{
    public class BusquedaRecursiva : Busqueda
    {
        public override int ObtenerPosicion(int[] numeros, int valorBuscado, int izquierda = 0, int derecha = 0)
        {
            derecha = derecha == 0 ? numeros.Length - 1 : derecha;
                        
            if (izquierda > derecha)
                return -1;

            int indiceCentral = Convert.ToInt32(Math.Floor(Convert.ToDouble(izquierda + derecha) / 2));

            int valorCentral = numeros[indiceCentral];

            if (valorCentral == valorBuscado)
                return indiceCentral;

            if (valorBuscado < valorCentral)
                derecha = indiceCentral - 1;
            else
                izquierda = indiceCentral + 1;

            return ObtenerPosicion(numeros, valorBuscado, izquierda, derecha);
        }
    }
}