using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_CONCEPTS.polymorphism.MethodOverRiding
{
    class PartTimeEmployee:Employee
    {
        internal string empName;

        public void calculatesalary()
        {
            Console.WriteLine("3000");
        }
    }
}
