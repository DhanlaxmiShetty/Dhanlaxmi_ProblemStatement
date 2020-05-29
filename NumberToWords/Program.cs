using System;

namespace NumberToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a number to convert to words : ");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0}", ConvertNumberToWords.NumberToWord(number));
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
