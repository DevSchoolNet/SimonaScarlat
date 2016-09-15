using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NInjectHomework
{
    public class Dog : IAnimal
    {
        public string getBark()
        {
            return "Ham Ham";
        }

        public string getFavouriteFood()
        {
            return "bones";
        }
    }
}
