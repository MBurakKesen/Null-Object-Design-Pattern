using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Object_Design_Pattern
{
    public static class Extensions
    {
        public static IEmployee NullCheck(this IEmployee employee)
        {
            return employee ?? NullEmployee.Nil;
        }
    }
}
