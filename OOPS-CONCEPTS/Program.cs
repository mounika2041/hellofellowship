using OOPS_CONCEPTS.ClassObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_CONCEPTS
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassObject.Fruit apple = new Fruit("apple", "red");
            apple.FruitDetails();
            ClassObject.Fruit orange = new Fruit("orange", "yellow");
            orange.FruitDetails();
            Console.ReadLine();
        }
    }
}
