namespace _6._5.InterfaceAndPolymorphism
{
    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            System.Console.WriteLine("Sending SMS...");
        }
    }
}


