using System;

namespace _4._1.AccessModidiers
{
    public class Customer
    {
        public int  Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(excluderOrders: true);
            if(rating == 0)
                Console.WriteLine("Promoted to Leavel 1");
            else
                Console.WriteLine("Promoterd to Level 2");

        }
        public int CalculateRating(bool excluderOrders)
        {
            return 0;
        }
    }
}
