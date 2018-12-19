using System;

namespace p_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            string customer = Console.ReadLine();
            string dayOfWeack = Console.ReadLine();
            double sum = 0;

            if (customer == "Students")
            {
                if (dayOfWeack == "Friday")
                {
                    sum = counter * 8.45;
                }
                else if (dayOfWeack == "Saturday")
                {
                    sum = counter * 9.80;
                }
                else
                {
                    sum = counter * 10.46;
                }
                if (counter >= 30)
                {
                    sum *= 0.85;
                }

            }
            else if (customer == "Business")
            {
                if (counter >= 100)
                {
                    counter -= 10;
                }
                if (dayOfWeack == "Friday")
                {
                    sum = counter * 10.90;
                }
                else if (dayOfWeack == "Saturday")
                {
                    sum = counter * 15.60;
                }
                else
                {
                    sum = counter * 16.00;
                }
            }
            else
            {
                if (dayOfWeack == "Friday")
                {
                    sum = counter * 15.00;
                }
                else if (dayOfWeack == "Saturday")
                {
                    sum = counter * 20.00;
                }
                else
                {
                    sum = counter * 22.50;
                }
                if (counter >= 10 && counter <= 20)
                {
                    sum *= 0.95;
                }
            }

            Console.WriteLine($"Total price: {sum:f2}");
        }
    }
}
