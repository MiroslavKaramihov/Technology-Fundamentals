using System;
using System.Collections.Generic;
using System.Linq;

namespace p_07
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> list = new List<Item>();
            List<Box> boxes = new List<Box>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0]=="end")
                {
                    break;
                }

                string name = input[1];
                double price = double.Parse(input[3]);
                string serialNumber = input[0];
                string item = input[1];
                int quantyty = int.Parse(input[2]);
                double priceForBox = quantyty * price;


                Item products = new Item();
                Box box = new Box();

                products.Name = name;
                products.Price = price;

                list.Add(products);

                box.SerialNumber = serialNumber;
                box.ItemName = item;
                box.ItemQuantyty = quantyty;
                box.PriceForBox = priceForBox;
                box.Price = price;

                boxes.Add(box);
                
            }

          var result=  boxes.OrderByDescending(x => x.PriceForBox);

            foreach (var item in result)
            {
                Console.WriteLine(item.SerialNumber);
                Console.WriteLine($"-- {item.ItemName} - ${item.Price:f2}: {item.ItemQuantyty}");
                Console.WriteLine($"-- ${item.PriceForBox:f2}");
            }
        }
    }
    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    public class Box
    {
        public string SerialNumber { get; set; }
        public string ItemName { get; set; }
        public int ItemQuantyty { get; set; }
        public double PriceForBox { get; set; }
        public double Price { get; set; }
    }
}
