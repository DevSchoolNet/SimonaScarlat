using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class ClientLidl : IClient
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Lidl a primit mesajul " + message);
        }
    }
}
