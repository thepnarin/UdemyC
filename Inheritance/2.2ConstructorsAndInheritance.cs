using System;

namespace _4._2.ConstructorsAndInheritance
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            :base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized. {0}",registrationNumber);
        }
    }
}
