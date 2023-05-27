using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Enter a non-negative integer between 0 and 999:");
            int number = int.Parse(Console.ReadLine());
            string result = ReadNumber(number);
            Console.WriteLine("The number {0} is read as: {1}", number, result);
        }
        static string ReadNumber(int number)
        {
            if (number == 0)
            {
                return "zero";
            }
            else if (number < 0 || number > 999)
            {
                return "Out of ability";
            }
            
            string[] units = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] teens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

            string result = "";

            int hundredsDigit = number / 100;
            int tensDigit = (number % 100) / 10;
            int unitsDigit = number % 10;

            if (hundredsDigit > 0)
            {
                result += units[hundredsDigit] + " hundred";
                if (tensDigit > 0 || unitsDigit > 0)
                {
                    result += " and";
                }
            }

            if (tensDigit > 1)
            {
                result += " " + tens[tensDigit];
                if (unitsDigit > 0)
                {
                    result += " " + units[unitsDigit];
                }
            }
            else if (tensDigit == 1)
            {
                result += " " + teens[unitsDigit];
            }
            else
            {
                result += " " + units[unitsDigit];
            }

            return result;
            }
    }
}
