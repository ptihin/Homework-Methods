using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Bigger_Number
{
    class BiggerNumber
    {
        static int GetMax(int firstNumber, int secondNumber)
        {
            int biggerNum = Math.Max(firstNumber, secondNumber);
            return biggerNum;
        }
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int max = GetMax(firstNumber, secondNumber);
            Console.WriteLine(max);



        }
    }
}
