using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToWords
{
    public class ConvertNumberToWords
    {
        public static string NumberToWord(int number)
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

        static string NumWords(double num)
        {
            string[] numbers = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tensList = new string[] { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty" };
            string[] remainingList = new string[] { "thousand", "million" };

            string words = "";

            bool tens = false;

            if (num < 0)
            {
                words += "negative ";
                num *= -1;
            }

            int power = (remainingList.Length + 1) * 3;

            while (power > 3)
            {
                double pow = Math.Pow(10, power);
                if (num >= pow)
                {
                    if (num % pow > 0)
                    {
                        words += NumWords(Math.Floor(num / pow)) + " " + remainingList[(power / 3) - 1] + ", ";
                    }
                    else if (num % pow == 0)
                    {
                        words += NumWords(Math.Floor(num / pow)) + " " + remainingList[(power / 3) - 1];
                    }
                    num %= pow;
                }
                power -= 3;
            }

            if (num >= 1000)
            {
                if (num % 1000 > 0) words += NumWords(Math.Floor(num / 1000)) + " thousand, ";
                else words += NumWords(Math.Floor(num / 1000)) + " thousand";
                num %= 1000;
            }

            if (0 <= num && num <= 999)
            {
                if ((int)num / 100 > 0)
                {
                    words += NumWords(Math.Floor(num / 100)) + " hundred";
                    num %= 100;
                }

                if ((int)num / 10 > 1)
                {
                    if (words != "")
                        words += " ";
                    words += tensList[(int)num / 10 - 2];
                    tens = true;
                    num %= 10;
                }

                if (num < 20 && num > 0)
                {
                    if (words != "" && tens == false)
                        words += " ";
                    words += (tens ? "-" + numbers[(int)num - 1] : numbers[(int)num - 1]);
                    num -= Math.Floor(num);
                }
            }

            return words;
        }
    }
}
