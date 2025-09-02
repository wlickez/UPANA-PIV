namespace factorymethod.models.interfaces
{
    public class SmsNotification : INotification
    {
        public void SendNotification(string message)
        {
            System.Console.WriteLine($"Sendin a SMS: {message}");
        }
    }
}