namespace factorymethod.models
{
    public class Cerveza : BebidaEmbriagante
    {
        public override int CuantoMeEmbriagaPorHora()
        {
            return 5;
        }
    }
}