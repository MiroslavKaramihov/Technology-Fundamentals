using System;


namespace p_07
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalSum = 0;
            

            try
            {
                while (true)
                {
                    decimal coins = decimal.Parse(Console.ReadLine());

                    if (coins == 0.10M || coins == 0.2m || coins == 0.5m || coins == 1.00m || coins == 2.00m)
                    {
                        totalSum += coins;
                    }
                    else
                    {
                        Console.WriteLine($"Cannot accept {coins:f2}");
                    }

                }
            }
            catch (Exception)
            {

                while (true)
                {
                    string products = Console.ReadLine();

                    if (products == "End")
                    {
                        Console.WriteLine($"Change: {totalSum:f2}");
                        break;
                    }
                    else if (products == "Nuts")
                    {
                        if (totalSum >= 2.00m)
                        {
                            Console.WriteLine("Purchased nuts");
                            totalSum = totalSum - 2.00m;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }
                    else if (products == "Water")
                    {
                        if (totalSum >= 0.70m)
                        {
                            Console.WriteLine("Purchased water");
                            totalSum -= 0.70m;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }
                    else if (products == "Crisps")
                    {
                        if (totalSum >= 1.50m)
                        {
                            Console.WriteLine("Purchased crisps");
                            totalSum -= 1.50m;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }
                    else if (products == "Soda")
                    {
                        if (totalSum >= 0.80m)
                        {
                            Console.WriteLine("Purchased soda");
                            totalSum -= 0.80m;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }
                    else if (products == "Coke")
                    {
                        if (totalSum >= 1.00m)
                        {
                            Console.WriteLine("Purchased coke");
                            totalSum -= 1.00m;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid product");
                    }
                }

            }

        }
    }
}
