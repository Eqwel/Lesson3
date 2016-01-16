//Определить расстояние между двумя точками на плоскости с координатами X1, Y1 и X2, Y2. Формула для расчета (при расчетах может
//понадобится метод Math.Sqrt()):                                                                                              
//d = √(X2 – X1)2 + (Y2 – Y1)2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1_04
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, d;

            Console.WriteLine("Input point X1, Y1");

            if (!Double.TryParse(Console.ReadLine(), out x1))
            {
                Console.WriteLine("Error");
                return;
            }

            if (!Double.TryParse(Console.ReadLine(), out y1))
            {
                Console.WriteLine("Error");
                return;
            }
            Console.WriteLine("Input point X2, Y2");

            if (!Double.TryParse(Console.ReadLine(), out x2))
            {
                Console.WriteLine("Error");
                return;
            }

            if (!Double.TryParse(Console.ReadLine(), out y2))
            {
                Console.WriteLine("Error");
                return;
            }

            d = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1));

            Console.WriteLine("Distance between X1,Y1 and X2,Y2 = {0}", d);
        }
    }
}
