//Написать консольное приложение для перевода температуры из шкалы Цельсия в шкалу Фаренгейта. Значение температуры задается
//пользователем с консоли. Обеспечить вывод результата с точностью до сотых градуса.
//Формула для расчета: t_F = 9 \5 * t_C + 32. 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal t_F, t_C;
            Console.WriteLine("Input temperature in Celsius");
            if (!decimal.TryParse(Console.ReadLine(), out t_C))
            {
                Console.WriteLine("Error");
                return;
            }
            t_F = (9/5)*t_C + 32;
            Console.WriteLine("Temperature {0} in Celsius = {1} in Fahrenheit",t_C,t_F);

        }
    }
}
