using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1ThurLabTask4___First_Look_at_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number1;
            decimal number2;
            decimal userValue;
            decimal result;

            number1 = 11;
            number2 = 7;

            Console.Write("Please enter a value: ");
            userValue = decimal.Parse(Console.ReadLine());

            result = (number1 * number2) / userValue;

            Console.WriteLine("The result of {0:N} times {1:N} divided by {2:N} is {3:N}", number1, number2, userValue, result);

            Console.ReadLine();
            
        }
    }
}
