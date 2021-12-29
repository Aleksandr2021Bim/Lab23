using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Задание_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello инженер! Давайте проверим метод с факториалом");
            FactorialAsync();

            Console.ReadKey();
        }

        static void Method(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Thread.Sleep(100);
            Console.WriteLine($"Факториал числа {n} равен {result}");
        }

        static async void FactorialAsync()
        {
            Console.WriteLine("Метод FactorialAsync начал работу");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Метод FactorialAsync закончил работу");
            await Task.Run(() => Method(n));
            Console.WriteLine("");
        }
    }
}
