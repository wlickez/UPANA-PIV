namespace Models
{
    public abstract class Busqueda
    {
        public abstract int ObtenerPosicion(int[] numeros, int valorBuscado, int izquierda = 0, int derecha = 0);
    }
}