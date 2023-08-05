using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Object_Design_Pattern
{
    public class EmployeesService
    {
        EmployeeRepository employeeRepository;
        public EmployeesService(EmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public IEmployee GetEmployeByName(string name)
        {
            return employeeRepository.GetSingle(e => e.Name == name).NullCheck();
        }
    }
}
