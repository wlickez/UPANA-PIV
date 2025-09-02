namespace Api2.Models
{
    public class Datos
    {               
        public string Nombre { get; set; }
        public string Contenido { get; set; }

        public Datos()
        {
           
        }

        public Datos(string nombre, string contenido)
        {
            Nombre = nombre;
            Contenido = contenido;
        }
    }
}
