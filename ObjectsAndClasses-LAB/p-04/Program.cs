using System;
using System.Collections.Generic;
using System.Linq;

namespace p_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> currentList = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('_').ToArray();

                string type = input[0];
                string name = input[1];
                string time = input[2];

                Song song = new Song();

                song.Name = name;
                song.TypeList = type;
                song.Time = time;

                currentList.Add(song);
            }

            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (var item in currentList)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else
            {
                foreach (var item in currentList)
                {
                    if (item.TypeList == typeList)
                    {

                        Console.WriteLine(item.Name);
                    }
                }
            }
        }
    }

    public class Song
    {


        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
