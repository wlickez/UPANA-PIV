using ObserverPatron.Interfaces;
using System;

namespace ObserverPatron.Models
{
    public class Logger : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("Log entry created: " + message);
        }
    }
    
    
}
