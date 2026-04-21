using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Demo
{
    class Program
    {
        public void Test()
        {
            Console.WriteLine("First Method : Method without args");
        }

        // method with same signature is not allowed

        //public void Test()
        //{
        //    Console.WriteLine("First Method : Method without args");
        //}

        // method with change in only return type is not allowed
        //public string Test()
        //{
        //    Console.WriteLine("First Method : Method without args");
        //}

        public void Test(int i)
        {
            Console.WriteLine("Second Method : Method with int arg");
        }
        public void Test(string s)
        {
            Console.WriteLine("Third Method : Method with string arg");
        }
        public void Test(string s, string st)
        {
            Console.WriteLine("Fourth Method : Method with string arg with different numbers");
        }
        public void Test(int i, string st)
        {
            Console.WriteLine("Fifth Method : Method with different types of args");
        }
        public void Test(string s, int i)
        {
            Console.WriteLine("Seventh Method : Method with different types of args with different sequence");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test(); // will call method without args
            p.Test(12345678); // will call method with int arg
            p.Test("Demo");  // will call method with string arg
            p.Test("Demo", "Test"); // will call method with two string args.
            p.Test(12345, "Demo"); // will call method with one int and one string args.
            p.Test("Demo", 12345); // will call method with one string and on int args.



            Console.ReadLine();
        }
    }
}
