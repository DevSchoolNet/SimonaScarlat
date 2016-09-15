using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NInjectHomework
{
    public class Cat : IAnimal
    {
        public string getBark()
        {
            return "miau miau";
        }

        public string getFavouriteFood()
        {
            return "meat";
        }
    }
}
