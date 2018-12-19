using System;
using System.Linq;
using System.Collections.Generic;

namespace p_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).ToArray();

            var list = new List<Articals>();
            var articals = new Articals();

            string titele = input[0];
            string content = input[1];
            string author = input[2];

            list.Add(articals);

            articals.Titele = titele;
            articals.Content = content;
            articals.Author = author;

            int n = int.Parse(Console.ReadLine());

            int counter = 0;

            while (counter!=n)
            {
                string[] nextLine = Console.ReadLine().Split(": ",StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (nextLine[0]=="Edit")
                {
                    articals.Content = nextLine[1];
                }
                else if (nextLine[0]== "ChangeAuthor")
                {
                    articals.Author = nextLine[1];
                }
                else
                {
                    articals.Titele = nextLine[1];
                }
                counter++;
            }

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Titele} - {item.Content}: {item.Author}");
            }
        }

    }
    public class Articals
    {
        public string Titele { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
}
