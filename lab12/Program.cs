using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Сircle.Сircumference();
            Сircle.Square();
            Сircle.Сoordinates();
            Console.ReadKey();
        }
    }
    static class Сircle
    {
        static int r=10;
        static int Х1=11;
        static int Y1=4;

        static public void Сircumference()
        {
            double P = 2 * Math.PI * r;
            Console.WriteLine("Длина окружности={0:.000}", P);
        }

        static public void Square()
        {
            double S = Math.PI * r * r;
            Console.WriteLine("Площадь круга={0:.000}", S);
        }
        static public void Сoordinates()
        {
            double D = Math.Sqrt(Math.Pow(Х1, 2) + Math.Pow(Y1, 2));
            if (D<=r)
            {
                Console.WriteLine("Точка попадает в окружность!");
            }
            else
            {
                Console.WriteLine("Точка не попадает в окружность!");
            }
        }

    }
}
