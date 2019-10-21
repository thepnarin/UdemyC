using System;

namespace _4._2.ConstructorsAndInheritance
{
    public class Vehicle
    {
        private readonly string _registrationNumber;
        public Vehicle()
        {
            Console.WriteLine("Vehicle is being initialized.");
        }
        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle is being initiialized. {0}",registrationNumber);
        }
    }
}
