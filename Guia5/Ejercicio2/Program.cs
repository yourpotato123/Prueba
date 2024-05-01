using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantnum;
            uint fibo, num1, num2;
            cantnum = 0;
            num1 = 0;
            num2 = 1;
            fibo = 0;

            Console.WriteLine("Ingrese hasta que número realizar Fibonacci.");
            cantnum=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci 1: {0}\nFibonacci 2: {1}",num1,num2);
            for (int i = 2; i < cantnum; i++)
            {
                fibo = num1 + num2;
                num1 = num2;
                num2 = fibo;
                Console.WriteLine("Fibonacci {0}: {1}", i+1, fibo);
            }
            Console.ReadLine();
        }
    }
}
