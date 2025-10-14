using ObserverPatron.Interfaces;

namespace ObserverPatron.Models
{
    public class EmailNotifier : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("Email sent: " + message);
        }


    }
}
