using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CreateClass.Employee;

namespace CreateClass
{
    public class Employee : Person, ICloneable
    {
        public int salary = 1500;
        public String profession = "soldier";
       

        

        public Employee(String name, int birthDate, Gender gender, int salary, String profession) : base("Nick", 1944, Gender.Male)
        {
            this.salary = salary;
            this.profession = profession;
        }

        internal Room Room { get; private set; }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room(1500 , "soldier" , 14);
            return newEmployee;
        }


        public override string ToString()
        {
            return salary + " , " + profession;
        }










    }
}
