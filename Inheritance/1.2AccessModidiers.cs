namespace _4._1.AccessModidiers
{
    partial class Program
    {
        public class GoldCustomer : Customer
        {
            public void OfferVouchar()
            {
                var ratting = this.CalculateRating(excluderOrders: true);
            }
        }
    }
}
