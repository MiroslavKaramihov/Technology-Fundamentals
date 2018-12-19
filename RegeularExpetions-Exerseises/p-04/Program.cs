using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace p_04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BarProduct> listBarProducts = new List<BarProduct>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of shift")
                {
                    break;
                }

                string namePatern = @"%[A-Z][a-z]+%";
                Regex nameRegex = new Regex(namePatern);
                var isValidName = nameRegex.IsMatch(input);

                string producktPatern = @"<\w+>";
                Regex productRegex = new Regex(producktPatern);
                var isValidProduckt = productRegex.IsMatch(input);

                string quantityPatern = @"\|[0-9]+\|";
                Regex quantityRegex = new Regex(quantityPatern);
                var isValidQuantity = quantityRegex.IsMatch(input);

                string pricePattern = @"[0-9]+\.?[0-9]+?\$";
                Regex priceRegex = new Regex(pricePattern);
                var isValidPrice = priceRegex.IsMatch(input);

                if (isValidName && isValidProduckt && isValidQuantity && isValidPrice == true)
                {
                    var currSet = new BarProduct();

                    var validName = nameRegex.Matches(input);
                    string name = validName[0].Value;
                    string originalName = "";

                    for (int i = 0; i < name.Length; i++)
                    {
                        if (char.IsLetter(name[i]))
                        {
                            originalName += name[i];
                        }
                    }

                    currSet.Name = originalName;

                    var validProduct = productRegex.Matches(input);
                    string product = validProduct[0].Value;
                    string originalProduct = "";

                    for (int i = 0; i < product.Length; i++)
                    {
                        if (char.IsLetter(product[i]))
                        {
                            originalProduct += product[i];
                        }
                    }

                    currSet.Produckt = originalProduct;

                    var validQuantity = quantityRegex.Matches(input);
                    string quantity = validQuantity[0].Value;
                    string originalQuantity = "";

                    for (int i = 0; i < quantity.Length; i++)
                    {
                        if (char.IsDigit(quantity[i]))
                        {
                            originalQuantity += quantity[i];
                        }
                    }

                    var quant = int.Parse(originalQuantity);

                    currSet.Quantity = quant;

                    var validPrice = priceRegex.Matches(input);
                    string pr = validPrice[0].Value;
                    string orginPR = "";

                    for (int i = 0; i < pr.Length; i++)
                    {
                        if (pr[i]!='$')
                        {
                            orginPR += pr[i];
                        }
                    }

                    var price = decimal.Parse(orginPR);
                    currSet.Price = price;

                    listBarProducts.Add(currSet);
                }
            }

            decimal result = 0;

            foreach (var item in listBarProducts)
            {
                Console.WriteLine($"{item.Name}: {item.Produckt} - {item.Quantity*item.Price:f2}");
                result += item.Quantity * item.Price;
            }
            Console.WriteLine($"Total income: {result:f2}");
        }

        class BarProduct
        {
            public string Name { get; set; }
            public string Produckt { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
        }
    }
}
