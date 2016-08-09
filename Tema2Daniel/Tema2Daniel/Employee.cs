using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Daniel
{
    class Employee:Person
    {

        public string employeeId;

        public Employee(string employeeId, string name, string phone, string email) : base(name, phone, email)
        {
            this.employeeId = employeeId;
        }
      

        public override string ToString()
        {
            return base.ToString() + "EmployeeId: " + this.employeeId;
        }
    }
}
