namespace Models
{
    public class BusquedaWhile : Busqueda
    {
        public override int ObtenerPosicion(int[] numeros, int valorBuscado, int izquierda = 0, int derecha = 0)
        {
            if (derecha == 0)
                derecha = numeros.Length - 1;

            while (izquierda <= derecha)
            {
                int indiceCentral = (int)Math.Floor((double)(izquierda + derecha) / 2);

                int valorCentral = numeros[indiceCentral];

                if (valorCentral == valorBuscado)
                    return indiceCentral;

                if (valorBuscado < valorCentral)
                    derecha = indiceCentral - 1;
                else
                    izquierda = indiceCentral + 1;

            }

            return -1;
        }
    }
}