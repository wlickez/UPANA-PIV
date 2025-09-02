namespace factorymethod.models.interfaces.Factory
{
    public class SmsFactory : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new SmsNotification();
        }
    }

}