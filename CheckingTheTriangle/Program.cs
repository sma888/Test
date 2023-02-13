using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingTheTriangle
{
    public class Program
    {
        static void Main(string[] args)
        {
            double a,b,c;
            Console.Write("Введите a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c = ");
            c = Convert.ToDouble(Console.ReadLine());

            Core core = new Core();
            
            if(core.ExistTest(a, b, c) == true)
            {
                Console.WriteLine("Треугольник существует");
            }
            else Console.WriteLine("Треугольник не существует");
            Console.ReadKey();
        }
    }
}
