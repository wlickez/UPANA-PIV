namespace Api2.Models
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public List<Nota> Notas { get; set; }
    }
}
