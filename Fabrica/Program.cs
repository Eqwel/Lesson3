using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Console.Write("Input Width\t");
            //double width = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Input Heigth\t");
            //double height = Convert.ToDouble(Console.ReadLine());
            double width;
            double height;
            Console.Write("Input Width\t");

            if (!double.TryParse(Console.ReadLine(),out width))
            {
                Console.WriteLine("error");
                return;
            }
            Console.Write("Input Height\t");

            if (!double.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("error");
                return;
            }

            double glassArea = width*height*2;
            double woodLength = 2*(width + height)*1.25;
            Console.WriteLine("Glass area = {0}", glassArea);
            Console.WriteLine("Wood length = {0}", woodLength);
        }
    }
}