using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_CONCEPTS.Inheritance
{
    class Car
    {
        public string Brand { get; internal set; }

        public void start()
        {
            Console.WriteLine("Vehicle starts");
        }
    }
}
