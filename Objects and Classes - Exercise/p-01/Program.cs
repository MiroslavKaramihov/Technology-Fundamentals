using System;

namespace p_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string[] phrases = new string[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            string[] events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            string[] authors = new string[]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            string[] sitys = new string[] 
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            RandometArray(phrases);
            RandometArray(events);
            RandometArray(sitys);
            RandometArray(authors);

            for (int i = 0; i < input; i++)
            {
                Console.WriteLine($"{phrases[i]} {events[i]} . {authors[i]} – {sitys[i]}");
            }
        }

        private static string[] RandometArray(string[] array)
        {
            Random result = new Random();

            for (int i = 0; i < array.Length; i++)
            {
               var newIndex= result.Next(0, array.Length);

                var valueTempt = array[i];
                array[i] = array[newIndex];
                array[newIndex] = valueTempt;

            }
            return array;
        }
    }
}
