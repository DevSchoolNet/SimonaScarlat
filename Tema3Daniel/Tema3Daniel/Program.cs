using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema3Daniel
{
    class Program
    {
        delegate string RemoveVoewls(string word);
        static void Main(string[] args)
        {
            
            RemoveVoewls removeVoyels=delegate(string word)
            {
                string voyels = "aeiou";
                return new string(word.Where(c => !voyels.Contains(c)).ToArray());
            };

            Console.WriteLine("Enter word: ");
            string wordInput="";
            wordInput = Console.ReadLine();


            Console.WriteLine(removeVoyels.Invoke(wordInput));
        }
    }
}
