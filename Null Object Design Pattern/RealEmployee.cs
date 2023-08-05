using System;
using System.Collections.Generic;
using System.Text;

namespace Null_Object_Design_Pattern
{
    public class RealEmployee : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public void GetFullName()
        {
            Console.WriteLine($"{Name} {Surname}");
        }
    }
}
