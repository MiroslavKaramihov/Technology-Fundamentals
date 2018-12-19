using System;

namespace p_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double snowballValue = 0;
            double maxValue = 0;
            double maxSnow = 0;
            double maxTime = 0;
            double maxQualiti = 0;
            double resultVlue = 0;

            for (int i = 0; i < n; i++)
            {
                double snowballSnow = double.Parse(Console.ReadLine());
                double snowballTime = double.Parse(Console.ReadLine());
                double snowballQualiti = double.Parse(Console.ReadLine());

                snowballValue = snowballSnow / snowballTime;

                resultVlue = Math.Pow(snowballValue, snowballQualiti);
                
                if (maxValue <= resultVlue)
                {
                    maxValue = resultVlue;
                    maxSnow = snowballSnow;
                    maxTime = snowballTime;
                    maxQualiti = snowballQualiti;
                }
            }
            Console.WriteLine($"{maxSnow} : {maxTime} = {maxValue} ({maxQualiti})");
        }
    }
}
