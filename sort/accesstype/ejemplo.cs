namespace Models
{

    public class Ejemplo
    {
        private string Nombre { get; set; }
        protected string Apellido { get; set; }
        public void AsignarNombre(string nombre)
        {
            Nombre = nombre;
        }

        public string DevolverNombre()
        {
            return Nombre;
        }
    }
}