using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_PROGRAM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO RF-PROGRAM");
            Human human = new Human();
            human.Speek();
            Console.ReadLine();
        }
    }
}
