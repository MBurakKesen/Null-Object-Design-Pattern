using System;
using System.Collections.Generic;
using System.Text;

namespace Null_Object_Design_Pattern
{
    public interface IEmployee
    {
        int Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        void GetFullName();
    }
}
