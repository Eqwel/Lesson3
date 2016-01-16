//Поменять местами значения двух переменных целого типа А и B без использования третьей переменной. Переменные вводятся с консоли.
//Результат выводится на экран.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Input A, B");
            if (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Error");
                return;
            }
            if (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Error");
                return;
            }
            a = a^b;
            b = a^b;
            a = a^b;
            Console.WriteLine("A = {0}, B = {1}", a, b);
        }
    }
}
