using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersices
{
    class Program
    {
        static void Main(string[] args)
        {
            Person myPerson = new Person(24, "Pesho");

            Console.WriteLine(myPerson.getName());
        }

        class Person
        {
            private int age = 44;

            private string name = "Dancho";

            public Person(int ag, string nm)
            {
                this.age = ag;
                this.name = nm;
            }

            public string getName()
            {
                return this.name;
            }
        }
    }
}
