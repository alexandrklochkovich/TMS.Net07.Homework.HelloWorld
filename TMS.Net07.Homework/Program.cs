using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine(); ;
            int b;
            {

                if (int.TryParse(a, out b))
                {
                    Console.Clear();
                    Console.WriteLine($"Введено число {b}");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Это не число");
                }
                Console.ReadLine();
            }
        }
    }
}
