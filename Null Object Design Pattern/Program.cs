using System;
using System.Collections.Generic;
using System.Text;

namespace Null_Object_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeesService service = new EmployeesService(new EmployeeRepository());

            IEmployee e = service.GetEmployeByName("Kerim");
            e.GetFullName();
        }
    }
}
