using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_8
{
    class Employee
    {
        public int ID { get; set; } // Properties?
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        public Employee(int ID, string Name, string Gender, int Salary)
        {
            this.ID = ID;
            this.Name = Name;
            this.Gender = Gender;
            this.Salary = Salary;

            
        }
    }
}
