//Написать консольное приложение, определяющее, является ли введенный пользователем год високосным (в программе может понадобится
//использование условных операторов if).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask1_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Iput year");
            if (!int.TryParse(Console.ReadLine(),out year))
            {
                Console.WriteLine("Error");
                return;
            }
            if ((year % 4 == 0) || (year % 100 != 0) && (year % 400 == 0)) 
            {
                Console.WriteLine("Year is leap");
               
            }
            else
            {
                Console.WriteLine("Year is not leap");
            }
            
        }
    }
}
