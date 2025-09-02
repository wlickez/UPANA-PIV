namespace Models3
{
    public interface ITrabajador
    {
        public string Nombre { get; set; }
        public DateTime FechaIngreso { get; set; }
    }

    public interface ITrabajadorEstado : ITrabajador
    {
        public bool TieneJubilacion { get; set; }
    }

    public interface ITrabajadorPrivado : ITrabajador
    {
        public int NumeroPoliza { get; set; }
    }

    public interface ITrabajadorEspecial : ITrabajadorEstado, ITrabajadorPrivado
    {

    }

    public class Trabajador : ITrabajadorEspecial
    {
        public bool TieneJubilacion { get ; set }
        public int NumeroPoliza { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaIngreso { get; set; }
    }

}