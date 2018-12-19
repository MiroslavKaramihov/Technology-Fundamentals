using System;
using System.Linq;

namespace p_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthField = int.Parse(Console.ReadLine());

            int[] bugsIndex = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] field = new int[lengthField];

            for (int i = 0; i < bugsIndex.Length; i++)
            {
                if (bugsIndex[i] > 0 && bugsIndex[i] < field.Length)
                {
                    field[bugsIndex[i]] = 1;

                }
            }

            while (true)
            {
                string[] comannds = Console.ReadLine().Split().ToArray();

                if (comannds[0] == "end")
                {
                    break;
                }

                int ladyBugIndex = int.Parse(comannds[0]);
                string directio = comannds[1];
                int flyLength = int.Parse(comannds[2]);

                int startIndex = field.First();
                int lastIndex = field.Last();

                if (field[ladyBugIndex] == 1)
                {
                    if (directio == "right")
                    {
                        field[ladyBugIndex] = 0;

                        if (field.Length - 1 >= ladyBugIndex + flyLength)
                        {
                            field[ladyBugIndex + flyLength] = 1;
                        }
                        else
                        {
                            for (int i = 0; i <= field.Length - 1; i++)
                            {
                                if (ladyBugIndex + flyLength < field.Length - 1)
                                {


                                    if (field[ladyBugIndex + flyLength] == 1)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        field[ladyBugIndex + flyLength] = 1;
                                        break;
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (directio == "left")
                    {
                        field[ladyBugIndex] = 0;

                        if (0 >= ladyBugIndex - flyLength)
                        {
                            field[ladyBugIndex - flyLength] = 1;
                        }
                        else
                        {
                            for (int i = 0; i <= field.Length - 1; i++)
                            {
                                if (ladyBugIndex + flyLength < field.Length - 1)
                                {


                                    if (field[ladyBugIndex - flyLength] == 1)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        field[ladyBugIndex - flyLength] = 1;
                                        break;
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }
                }

            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
