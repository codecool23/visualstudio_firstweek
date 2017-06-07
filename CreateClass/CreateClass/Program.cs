using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{

    public enum Gender
    {
        Male,
        Female
    }


    class Person

    {
        public String Name { get; set; }
        public String  BirthDate { get; set; } 
        public Gender Gender { get; set; }

        public override string ToString()
        {
            return "Person: " + Name + " " + BirthDate + " " + Gender ;
        }

        static void Main(string[] args)
        {
            Person person = new Person { Name = "John", BirthDate = "1994.02.04" , Gender = Gender.Male };
            Person person2 = new Person { Name = "Mary", BirthDate = "1994.04.06" , Gender = Gender.Female };
            Console.WriteLine(person);
            Console.WriteLine(person2);
            Console.Read();
        }
    }
}
