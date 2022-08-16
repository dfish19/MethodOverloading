using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {



        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = 0;
            var response = "";

            if (isTrue)
            {
                sum = num1 + num2;
                if (sum == 1)
                {
                    response = $"{sum} dollar";
                }
                else
                {
                    response = $"{sum} dollars";
                }
            }
            return response;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(3, 2, true));
            Console.WriteLine();

            Console.WriteLine(Add(1, 8, true));
            Console.WriteLine();

            Console.WriteLine(Add(9, 7, true));
        }
    }
}