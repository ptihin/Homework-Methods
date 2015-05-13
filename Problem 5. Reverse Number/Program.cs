using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Reverse_Number
{
    class Program
    {
        static double ReversedNumbers(double number)
        {
            string numToString = number.ToString();
            char[] reversed = numToString.ToCharArray();
            Array.Reverse(reversed);
            string reversedNumber = new string(reversed);
            double changed = double.Parse(reversedNumber);
            return changed;


        }
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double reversed = ReversedNumbers(number);

            Console.WriteLine(reversed);
        }
    }
}
