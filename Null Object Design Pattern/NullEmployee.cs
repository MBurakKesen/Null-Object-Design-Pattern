using System;
using System.Collections.Generic;
using System.Text;

namespace Null_Object_Design_Pattern
{
    public class NullEmployee : IEmployee
    {
        private NullEmployee(){}
        static NullEmployee nullEmployee;
        public static NullEmployee Nil => nullEmployee ?? (nullEmployee=new NullEmployee());
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public void GetFullName()
        {
            Console.WriteLine("This is Null Object");
        }
    }
}
