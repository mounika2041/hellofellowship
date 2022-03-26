using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_PROGRAM
{
    class Human
    {
        //variables
        //access-modifier datatype variable name
        public string name = "mouni", address = "wrgl";
        public double height = 5.26;
        //public decimal a=12.45m;

        //methods
        public void Speek()
        {
            Console.WriteLine("he/she can talk telugu&english");
            Console.WriteLine("name:{0} address:{1} height:{2}", name, address, height);
        }
    }
}
