
namespace factorymethod.models.interfaces
{
    public class EmailNotification : INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Sending a Email {message}");
        }
    }
}