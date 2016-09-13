using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DependencyInjection
{
    class ClientKaufland : IClient
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Kaufland a primit mesajul "+message);
        }
    }
}
