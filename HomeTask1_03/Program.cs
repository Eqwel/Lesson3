//Вычислить площадь поверхности и объем шара (S=4πr2, V=(4/3) πr3). Обеспечить вывод результата с точностью до сотых.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1_03
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double area, volume, r;

            Console.WriteLine("Input the radius of the circle");

           if(!Double.TryParse(Console.ReadLine(), out r))
            {
                Console.WriteLine("Error");
                return ;
            }

            area = 4*pi*(r*r);
            volume = (4/3)*pi*(r*r*r);

            Console.WriteLine("Area of the circle = {0}\nVolume of the circle = {1}",area,volume);
            
        }
    }
}
