namespace factorymethod.models.interfaces.Factory
{
    public class EmailFactory : NotificationFactory
{
    public override INotification CreateNotification()
    {
        return new EmailNotification();
    }
}
}