using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Null_Object_Design_Pattern
{
    public class EmployeeRepository
    {
        readonly List<IEmployee> employees = new List<IEmployee>()
        {
            new RealEmployee(){Id=1,Name="Burak",Surname="Kesen"},
            new RealEmployee(){Id=1,Name="Muhammed",Surname="Mami"},
            new RealEmployee(){Id=1,Name="Ali",Surname="Veli"},
        };

        public List<IEmployee> GetWhere(Func<IEmployee,bool> method) {
            return employees.Where(method).ToList();
        }
        public IEmployee GetSingle(Func<IEmployee,bool> method)
        {
            return employees.FirstOrDefault(method);
        }
    }
}
