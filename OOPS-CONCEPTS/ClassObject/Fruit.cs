using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_CONCEPTS.ClassObject
{
    class Fruit
    {
        //instance variable
        public string name, colour;

        public Fruit(string name, string colour)
        {
            this.name = name;
            this.colour = colour;
        }
        public void FruitDetails()
        {
            Console.WriteLine("fruit name:{0} colour:{1}", name, colour);
        }
    }
}
    

