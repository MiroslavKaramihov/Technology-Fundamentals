using System;
using System.Linq;
using System.Collections.Generic;

namespace p_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Articals> listOfArticals = new List<Articals>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");

                var newArtical = new Articals();

                newArtical.Titele = input[0];
                newArtical.Content = input[1];
                newArtical.Author = input[2];

                listOfArticals.Add(newArtical);
            }

            string finalComand = Console.ReadLine();

            var result = new List<Articals>();

            if (finalComand=="title")
            {
               result= listOfArticals.OrderBy(x => x.Titele).ToList();
            }
            else if (finalComand== "content")
            {
              result=  listOfArticals.OrderBy(x => x.Content).ToList();
            }
            else
            {
               result= listOfArticals.OrderBy(x => x.Author).ToList();
            }

            foreach (var item in result)
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
