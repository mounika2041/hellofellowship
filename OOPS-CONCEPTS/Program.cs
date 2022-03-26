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
            Fruit apple = new Fruit("apple", "red");
            apple.fruitDetails();
            Fruit orange = new Fruit("orange", "yellow");
            orange.fruitDetails();
            Console.ReadLine();
        }
    }

    class Fruit
    {
        public Fruit(string v1, string v2)
        {
        }

        internal void fruitDetails()
        {
            throw new NotImplementedException();
        }
    }
}
