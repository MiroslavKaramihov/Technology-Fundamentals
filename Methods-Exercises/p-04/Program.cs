using System;

namespace p_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string passwoard = Console.ReadLine();

            bool rulz = ValidPassCount(passwoard);
            bool rulz1 = ValiPassLeterAndDigits(passwoard);
            bool rulz2 = ValidDigitsCount(passwoard);

            if (rulz == true && rulz1 == true && rulz2 == true)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (rulz == false)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (rulz1 == false)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if (rulz2 == false)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }

        }

        private static bool ValidDigitsCount(string passwoard)
        {
            int count = 0;
            bool isTreu = false;

            for (int i = 0; i < passwoard.Length; i++)
            {
                if (passwoard[i] >= 48 && passwoard[i] <= 57)
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                isTreu = true;
            }
            else
            {
                isTreu = false;
            }

            return isTreu;
        }

        private static bool ValiPassLeterAndDigits(string passwoard)
        {
            bool isTrue = false;

            for (int i = 0; i < passwoard.Length; i++)
            {
                if (passwoard[i] >= 97 && passwoard[i] <= 122 || passwoard[i] >= 65 && passwoard[i] <= 90 || passwoard[i] >= 48 && passwoard[i] <= 57)
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
                    break;
                }
            }
            return isTrue;
        }

        private static bool ValidPassCount(string passwoard)
        {
            bool isTrue = false;

            if (passwoard.Length > 5 && passwoard.Length < 11)
            {
                isTrue = true;
                return isTrue;
            }
            return isTrue;
        }
    }
}
