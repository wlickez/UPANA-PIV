namespace Patrones.Factory
{
    public class NotificacionFactory
    {
        public INotificacion GetNotificacionFactory(MedioEnvio medioEnvio)
        {
            switch (medioEnvio)
            {
                case MedioEnvio.Mensaje:
                    return new NotificacionMensaje();

                case MedioEnvio.CorreoElectronico:
                    return new NotificacionCorreoElectronico();

                case MedioEnvio.Whatsapp:
                    return new NotificacionWhatsapp();

                default:
                    return new NotificacionMensaje(); 
            }
        }
    }    
}
