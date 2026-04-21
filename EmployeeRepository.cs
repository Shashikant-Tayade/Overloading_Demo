using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Demo
{
    class EmployeeRepository
    {
        public void GetEmployee(int id)
        {
            Console.WriteLine($"Fetching Record for id {id}");
        }
        public void GetEmployee(String deptName)
        {
            Console.WriteLine($"Fetching employees from department {deptName}");
        }
        public void GetEmployee(DateTime startDate, DateTime endDate)
        {
            Console.WriteLine($"Fetching employees hired between {startDate} and {endDate} ");
        }
    }
}
