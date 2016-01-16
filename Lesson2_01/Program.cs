using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //int month;
            //Console.WriteLine("Input month 1-12");
            //if (!int.TryParse(Console.ReadLine(), out month))
            //{
            //    Console.WriteLine("Error");
            //    return;
            //}
            //switch (month)
            //{
            //        case 1:
            //        Console.WriteLine("Juanary");
            //        break;
            //         case 2:
            //        Console.WriteLine("February");
            //        break;
            //         case 3:
            //        Console.WriteLine("March");
            //        break;
            //         case 4:
            //        Console.WriteLine("April");
            //        break;
            //         case 5:
            //        Console.WriteLine("May");
            //        break;
            //         case 6:
            //        Console.WriteLine("June");
            //        break;
            //         case 7:
            //        Console.WriteLine("July");
            //        break;
            //         case 8:
            //        Console.WriteLine("August");
            //        break;
            //         case 9:
            //        Console.WriteLine("September");
            //        break;
            //         case 10:
            //        Console.WriteLine("October");
            //        break;
            //         case 11:
            //        Console.WriteLine("November");
            //        break;
            //         case 12:
            //        Console.WriteLine("December");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid value");
            //        break;
            //}

            int a, b;
            Console.WriteLine("Input a range of numbers");
            if(!int.TryParse(Console.ReadLine(),out a))
            {
                Console.WriteLine("Error");
                return;
            }
            if (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Error");
                return;
            }
            for (int i = a; i <= b; i++)
            {
                if (i%2 == 0)
                    continue;
                
                    Console.WriteLine(i);

            }
        }

    }
}
