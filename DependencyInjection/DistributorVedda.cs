using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class DistributorVedda
    {
        public IClient Client { get; set; }

        public void NotifyClient(string message)
        {
            Client.SendMessage(message);
        }
    }
}
