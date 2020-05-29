using System;

namespace NumberToWords
{
    class Program
    {
        static string ConvertNumberToWords(int number)
        {
            string strWords = String.Empty;

            if (number == 0)
            {
                strWords = "Zero";
            }
            else
            {
                strWords = NumWords(number);
            }

            return strWords;
        }

        static string NumWords(int number)
        {
            return String.Empty;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to convert to words : ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}", ConvertNumberToWords(number));
            Console.ReadLine();
        }
    }
}
