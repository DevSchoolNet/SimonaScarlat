using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Daniel
{
    class Person
    {
        public string name;
        public string phone;
        public string email;
        
        public Person(string name, string phone, string email)
        {
            this.name = name;
            this.phone = phone;
            this.email = email;
        }

       

        public override string ToString() =>
            string.Format("Name: {0} Phone: {1} Email: {2}",this.name,this.phone,this.email);

        public static void Display(IEnumerable<Person> listOfPersons)
        {
            foreach(Person p in listOfPersons)
            {
                Console.WriteLine(p.ToString());
            }
            
        }
       
    }
}
