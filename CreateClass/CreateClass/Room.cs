using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Room : Employee
    {

        public int number = 14; 

        

        public Room(int salary, String profession, int number) : base("Nick", 1944, Gender.Male,1500, "soldier")
        {
            this.number = number;
        }

        public int Number { get; internal set; }

        public override string ToString()
        {
            return "Room number is: " + number;
        }
    }
}
