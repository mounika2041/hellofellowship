using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_CONCEPTS.polymorphism.MethodOverRiding
{
    class Employee
    {
        public string empname, address;
        public int Id;

        public void EmployeeDetails()
        {
            Console.WriteLine("emplyee Name:{0}", empname);
        }
        public void calculatesalary()
        {
            Console.WriteLine("5000");
        }
    }
}
