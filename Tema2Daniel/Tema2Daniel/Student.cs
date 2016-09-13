using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Daniel
{
    class Student :Person
    {
        public string studentId;

        public Student(string studentId,string name, string phone, string email) : base(name, phone, email)
        {
            this.studentId = studentId;
        }

        

        public override string ToString()
        {
            return base.ToString() + "Student Id: " + this.studentId;
        }

      
    }
}
