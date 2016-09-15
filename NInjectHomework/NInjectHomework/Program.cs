using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace NInjectHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            //kernel.Bind<IAnimal>().To<Dog>();
            //kernel.Rebind<IAnimal>().To<Cat>();
            kernel.Bind<IAnimal>().ToMethod(context =>
            {

                Console.WriteLine("Creating new animal");
                return new Dog();
            });
            var printer = kernel.Get<Printer>();
            printer.printAnimalInformation("Billy");

            Console.Read();
        }
    }
}
