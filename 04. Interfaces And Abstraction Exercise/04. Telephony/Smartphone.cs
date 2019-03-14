
namespace Telephony
{
    using System;
    using System.Text;

    public class Smartphone : ICalling, IBrowsing
    {
        public string Browse(string url)
        {
            foreach (var symbol in url)
            {
                if (char.IsDigit(symbol))
                {
                    return "Invalid URL!";
                }
            }

            return $"Browsing: {url}!";
        }

        public string Call(string number)
        {
            foreach (var symbol in number)
            {
                if (!char.IsDigit(symbol))
                {
                    return "Invalid number!";
                }
            }

            return $"Calling... {number}";
        }
    }
}