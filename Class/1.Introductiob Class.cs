using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Introductiob_Class
{   public class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0},I am {1}",to,Name);
        }
        public static Person parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            var person = Person.parse("john");
            person.Introduce("mosh");
        }
    }
}
