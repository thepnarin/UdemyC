using System;

namespace _2.Interitance
{
    public class Text : PersentationObject
    {
        public Text()
        {
        }

        public int FontSize { get; set; }
        public string FonrName { get; set; }
        public void Addtyperlink(string url)
        {
            Console.WriteLine("we added a link to"+url);
        }
    }
}
