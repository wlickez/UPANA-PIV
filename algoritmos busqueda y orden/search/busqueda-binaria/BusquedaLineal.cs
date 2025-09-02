namespace Models
{
    public class BusquedaLineal : Busqueda
    {
        public override int ObtenerPosicion(int[] numeros, int valorBuscado, int izquierda = 0, int derecha = 0)
        {
            int indice = -1;

            for (int i = 0; i < numeros.Length; i++)
            {
                int valorActual = numeros[i];

                if (valorActual == valorBuscado)
                {
                    indice = i;
                    break;
                }
            }

            return indice;
        }
    }

}