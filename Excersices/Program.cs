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
            Person myPerson = new Person();
        }

        class Person
        {
            private int age = 44;

            public Person()
            {
                Console.WriteLine("Hello Dancho");
            }
        }
    }
}
