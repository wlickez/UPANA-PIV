namespace factorymethod.models
{
    public class VinoTinto : BebidaEmbriagante
    {
        public override int CuantoMeEmbriagaPorHora()
        {
            return 20;
        }
    }
}