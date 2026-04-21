using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Demo
{
    class Payment_Processor_Main
    {
        static void Main(string[] args)
        {
            Payment_Processor pp = new Payment_Processor();
            pp.ProcessPayment(231045, 150.5m);
            pp.ProcessPayment(231045, "ABCDE","01/01/2029" );
            pp.ProcessPayment(10.3m, "Demo@gmail.com", false);
            Console.ReadLine();
        }


    }
}
