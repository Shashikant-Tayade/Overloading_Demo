using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Demo
{
    class EmployeeRepository_Main
    {
        static void Main(string[] args)
        {
            EmployeeRepository ER = new EmployeeRepository();
            ER.GetEmployee(101); // calling method that get int number as input
            ER.GetEmployee("IT"); // calling method that get string department.
            ER.GetEmployee(new DateTime(2025, 01, 01), DateTime.Now); // calling method that get start and end date as input.
            Console.ReadLine();
        }
    }
}
