
namespace Telephony
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {

            var phoneNumberInput = Console.ReadLine().Split();           
            var browsingInput = Console.ReadLine().Split();

            var smartPhone = new Smartphone();

            foreach (var number in phoneNumberInput)
            {
                Console.WriteLine(smartPhone.Call(number));
            }

            foreach (var url in browsingInput)
            {
                Console.WriteLine(smartPhone.Browse(url));
            }
        }
    }
}
