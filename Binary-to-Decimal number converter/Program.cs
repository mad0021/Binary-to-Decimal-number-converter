using System;

namespace Binary_to_Decimal_number_converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, c, k;

            Console.Write("Enter a 9 digit decimal number: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIn Binary: \n ");
            for (c= 13; c >= 0; c--)
            {
                k = n >> c;
                if (Convert.ToBoolean(k & 1))
                    Console.Write("1");
                else
                    Console.Write("0");
            }

            Console.ReadKey();
        }
    }
}
