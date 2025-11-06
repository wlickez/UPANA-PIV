using Practica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Servicios
{
    internal class Notificar : INotificar
    {
        public void SendReportByEmail(string email)
        {
            Console.WriteLine("Enviando notificacion a " + email);
        }
    }
}
