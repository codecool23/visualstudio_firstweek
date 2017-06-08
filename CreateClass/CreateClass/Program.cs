using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Person person = new Person("Nick", 1944, Gender.Male);
            Employee employee = new Employee("Nick", 1993, Gender.Male, 500, "soldier");
            Room room = new Room(1500,"soldier", 14);
            Console.WriteLine(person);
            Console.WriteLine(employee);
            Console.WriteLine(room);
            Console.Read();*/
            Employee Kovacs = new Employee("Géza", 1944, Gender.Male,  1000, "léhűtő");
            Room room = new Room(1500, "soldier" , 14);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.Room.number = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();
        }
    }
}
