// Antonio Ariza Gomez .NET 22
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(101, "Erik", "Male", 5000);
            Employee employee2 = new Employee(102, "Emilia", "Female", 10000);
            Employee employee3 = new Employee(103, "Hans", "Male", 40000);
            Employee employee4 = new Employee(104, "Urgot", "Male", 50000);
            Employee employee5 = new Employee(105, "Emil", "Other", 65000);

            Stack<Employee> myStack = new Stack<Employee>();

            myStack.Push(employee1); //Lägger in Empoyees i stacken med push metoden
            myStack.Push(employee2);
            myStack.Push(employee3);
            myStack.Push(employee4);
            myStack.Push(employee5);



            foreach (Employee StackItem in myStack) //läser in varje Employee item i stacken


            {
                Console.WriteLine($"Items left in the stack= {myStack.Count}"); // Skriver ut antal objekt kvar i stacken
                Console.WriteLine($"ID={StackItem.ID} Name= {StackItem.Name} Gender= {StackItem.Gender} Salary= {StackItem.Salary}");


            }
            Console.WriteLine("***************************");
            var PopStacks = myStack.Pop(); // Hämtar objekten med pop.metoden

            foreach (Employee StackItem in myStack) //Foreach för att gå igenom stacken med pop.metoden
            {
                Console.WriteLine($"ID={StackItem.ID} Name= {StackItem.Name} Gender= {StackItem.Gender} Salary= {StackItem.Salary}");
                Console.WriteLine($"Items left in the stack= {myStack.Count}");

            }


            Console.WriteLine("****************************peek");
            Employee emp1 = myStack.Peek(); // hämtar objekten för att använda peek metoden
            Console.WriteLine($"ID={emp1.ID} Name= {emp1.Name} Gender= {emp1.Gender} Salary= {emp1.Salary}");
            Console.WriteLine($"Items left in the stack= {myStack.Count}");
            Employee emp2 = myStack.Peek();
            Console.WriteLine($"ID={emp2.ID} Name= {emp2.Name} Gender= {emp2.Gender} Salary= {emp2.Salary}");
            Console.WriteLine($"Items left in the stack= {myStack.Count}");

            bool contains1 = myStack.Contains(emp2);

            if (contains1 == true) // IF-sats för att få ut i konsollen om emp2 finns eller inte
            {
                Console.WriteLine("Emp2 is in stack");
            }

            else
            {
                Console.WriteLine("Emp2 is not in stack");
            }

            Console.WriteLine("***************************************");


            List<Employee> emp = new List<Employee>(); // Gör en ny lista för att gå igenom contains, find och findall.

            emp.Add(employee1);
            emp.Add(employee2);
            emp.Add(employee3);
            emp.Add(employee4);
            emp.Add(employee5);

            bool contains = myStack.Contains(employee3);

            if (contains = true) //if-sats för att få ut i konsollen om employee 5 finns eller inte
            {
                Console.WriteLine("Employee5 does exist in the List");
            }
            else
            {
                Console.WriteLine("Employee5 does not exist in the List");
            }

            Employee empl = emp.Find(i => i.Gender == "Male"); // Find metoden för att se den första i listan som är "Male"
            Console.WriteLine($"ID={empl.ID} Name= {empl.Name} Gender= {empl.Gender} Salary= {empl.Salary}");

            Console.WriteLine("*********************************");
            Console.WriteLine("List of every male employee******" );

            List<Employee> empl1 = emp.FindAll(x=>x.Gender=="Male"); //FindAll metoden för att hitta alla " Male i listan
            foreach (Employee employee in empl1)
            {
            Console.WriteLine($"ID={employee.ID} Name= {employee.Name} Gender= {employee.Gender} Salary= {employee.Salary}");
                

            }
           

            




        }
    }
}

