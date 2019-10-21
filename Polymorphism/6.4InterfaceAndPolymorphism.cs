using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._5.InterfaceAndPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());
            encoder.Encode(new Video());
        }
    }
}
