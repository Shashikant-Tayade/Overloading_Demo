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
            //pp.ProcessPayment(101, 500);
            //pp.ProcessPayment(400, "12345", new DateTime(2026, 08, 01));
            //pp.ProcessPayment(800, "demo@gmail.com", true);
            Console.ReadLine();
        }


    }
}
