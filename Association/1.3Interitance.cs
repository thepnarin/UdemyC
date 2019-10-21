using System;

namespace _2.Interitance
{
    public class PersentationObject
    {
        public int width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied to clipbord.");
        }
        public void Duplicate()
        {
            Console.WriteLine("Object was duplicate.");
        }
    }
}
