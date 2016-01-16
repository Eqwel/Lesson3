//Вычислить площадь поверхности и объем цилиндра (S=2 π rh, V=π r2 h). Обеспечить вывод результата с точностью до сотых.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1_02
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double area, volume, r, h;

            Console.WriteLine("Input cylinder radius and height");
            r = Convert.ToDouble(Console.ReadLine());
            h = Convert.ToDouble(Console.ReadLine());

            area = 2*pi*r*h;
            volume = pi*(r*r)*h;

            Console.WriteLine("Cylinder area = {0}\nCylinder volume = {1}",area,volume );
        }
    }
}
