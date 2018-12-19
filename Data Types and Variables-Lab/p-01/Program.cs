using System;

namespace p_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());
            int thrNum = int.Parse(Console.ReadLine());
            int fourNum = int.Parse(Console.ReadLine());

            int result = ((firstNum + secNum) / thrNum) * fourNum;
            Console.WriteLine(result);
        }
    }
}
