using System;

namespace p_09
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, height = 0;

            length = double.Parse(Console.ReadLine());

            width = double.Parse(Console.ReadLine());

            height = double.Parse(Console.ReadLine());

           double value = (length * width * height) / 3;

            Console.Write("Length: ");
            Console.Write("Width: ");
            Console.Write("Height: ");
            Console.WriteLine("Pyramid Volume: {0:f2}", value);

        }
    }
}
