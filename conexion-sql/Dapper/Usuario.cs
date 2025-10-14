namespace DapperModels
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string NombreCompleto { get; set; }
        public string Clave { get; set; }
        public int CodigoEstado { get; set; }

        public override string ToString()
        {
            return $"Codigo: {Codigo} Nombre: {Nombre} NombreCompleto: {NombreCompleto} Estado: {CodigoEstado}";
        }
    }
}