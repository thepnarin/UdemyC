using System.Collections.Generic;
using System;

namespace _8.Indexers
{
    public class HttpCookie
    {
        private Dictionary<string, string>  _dictionary;
        public DateTime Expiry { get; set; }
        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }
        public void SetItem(string key,string value)
        {

        }
        public string GetItem(string key)
        {
            return null;
        }
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}
