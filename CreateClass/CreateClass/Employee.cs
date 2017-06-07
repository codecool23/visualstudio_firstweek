using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    public class Employee : Person
    {
        public String salary;
        public String profession;
        




        public override string ToString()
        {
            return "Person: " + Name + " " + BirthDate + " " + Gender + " " + salary + " " + profession ;
        }

       

        static void Main(string[] args)
        {
            Employee employee = new Employee { Name = "John", BirthDate = "1994.02.04", Gender = Gender.Male , salary = "5000" , profession = "Accountant" };
            Employee employee2 = new Employee { Name = "John", BirthDate = "1994.02.04", Gender = Gender.Male, salary = "8000", profession = "Analayst" };
            Employee employee3 = new Employee { Name = "John", BirthDate = "1994.02.04", Gender = Gender.Male, salary = "8000", profession = "Analayst"  };
            Console.WriteLine(employee);
            Console.WriteLine(employee2);
            Console.Read();
        }
    }
}
