using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_CONCEPTS.polymorphism.MethodOverloding
{
    class Addition
    {
        public void Add(int x,int y)
        {
            int z = x + y;
            Console.WriteLine("sum:" + z);
        }
        public void Add(int x,int y,int p)
        {
            int z = x + y + p;
            Console.WriteLine("sum:" + z);
        }
        //changing datatype
        public void Add(double x,int y,int p)
        {
            double z= x + y + p;
            Console.WriteLine("sum:" + z);
        }
        //changing order of parameters
        public void Add(int y,double x,int p)
        {
            double z = x + y + p;
            Console.WriteLine("sum:" + z);
        }
      
    }
}
