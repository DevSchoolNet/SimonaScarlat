using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class FactoryClient
    {
        public static IClient makeClientInstance(string selectedClient)
        {
            switch(selectedClient)
            {
                case "Kaufland":
                    return new ClientKaufland();
                case "Lidl":
                    return new ClientLidl();
                default: 
                    return new ClientMegaImage();
            }
                
        }
    }
}
