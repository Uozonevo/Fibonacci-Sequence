using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE2310_HW5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 1, num3;
            Console.WriteLine("==Fibonacci Sequence==");
            Console.Write(1 + "       ");
            for (int i = 0; i < 4; i++) 
            {
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
                Console.Write(num3 + "        ");
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
                Console.Write(num3 + "       ");
            } Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
                Console.Write(num3 + "      ");
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
                Console.Write(num3 + "     ");
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
                Console.Write(num3 + "    ");
            }
            Console.WriteLine();

        }
    }
}
