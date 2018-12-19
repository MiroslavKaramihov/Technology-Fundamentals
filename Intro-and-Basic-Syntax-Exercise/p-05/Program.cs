using System;
using System.Linq;

namespace p_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string newUser = user;



            var reversed = new string((from c in user.Select((value, index) => new { value, index })
                                       orderby c.index descending
                                       select c.value).ToArray());

            

            int counter = 0;
            

            while (true)
            {
                string pass = Console.ReadLine();
                
                if (reversed == pass)
                {
                    Console.WriteLine($"User {user} logged in.");
                    break;
                }
                counter++;
                if (counter==4)
                {
                    Console.WriteLine($"User {user} blocked!");
                    break;
                }

                Console.WriteLine("Incorrect password. Try again.");
            }

        }
    }
}
