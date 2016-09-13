using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Daniel
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("S100", "Popescu Ion", "0770568822", "popion@yahoo.com");
            Student student2 = new Student("S200", "Mircea Elena", "0785256254", "mirceaelena@yahoo.com");

            List<Student> listOfStudents = new List<Student>
            {
               student1,
               student2
            };

            IEnumerable<Person> listOfPersons = listOfStudents;
            Person.Display(listOfPersons);
            
            
            
        }
    }
}
