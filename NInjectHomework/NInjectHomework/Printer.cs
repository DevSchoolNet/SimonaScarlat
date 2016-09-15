using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NInjectHomework
{
    public class Printer
    {
        private readonly IAnimal _animal;

        public Printer(IAnimal animal)
        {
            _animal = animal;
        }

        public void printAnimalInformation(string animalName)
        {
            Console.WriteLine(animalName + " Bark: " + _animal.getBark() + " Favourite food: " + _animal.getFavouriteFood());
        }
    }
}
