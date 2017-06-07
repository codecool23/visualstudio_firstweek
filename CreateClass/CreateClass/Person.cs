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


    public class Person

    {
        public String name= "Nick";
        public int BirthDate = 1944;
        public Gender Gender;

         public Person(String name, int birthDate, Gender genders)
        {
            this.name = name;
            this.BirthDate = birthDate;
            this.Gender = genders;
        }

        public override string ToString()
        {
            return name + " , " + BirthDate + " , " + Gender.Male;
        }


    }
}
