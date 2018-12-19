using System;
using System.Collections.Generic;
using System.Linq;

namespace p_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> listOfMails = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "stop")
                {
                    break;
                }

                string mail = Console.ReadLine();

                if (mail.Last() == 's' || mail.Last() == 'k')
                {

                }
                else
                {
                    listOfMails.Add(name, mail);
                }
            }
            foreach (var item in listOfMails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
