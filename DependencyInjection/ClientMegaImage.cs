using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class ClientMegaImage : IClient
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Mega Image a primit mesajul " + message);
        }
    }
}
