using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechasEjercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hoy es {DateTime.Now.Day} del mes {DateTime.Now.Month} del año {DateTime.Now.Year}");
            Console.ReadKey();
        }
    }
}
