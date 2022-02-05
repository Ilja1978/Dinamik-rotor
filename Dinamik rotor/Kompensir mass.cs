using System;
using System.Collections.Generic;
using System.Text;

namespace Dinamik_rotor
{
    class Kompensir_mass
    {
        private const double p = 7.82;
        private double m, b, h, l;
        string Vibor;
        public double Shponka()
        {
            do
            {
                Console.Write("Введите длинну шпонки\t");
                string Dlin = Console.ReadLine();
                l = Convert.ToDouble(Dlin);
                Console.Write("Введите ширину\t");
                string Shir = Console.ReadLine();
                b = Convert.ToDouble(Shir);
                Console.Write("Введите высоту \t");
                string Vis = Console.ReadLine();
                h = Convert.ToDouble(Vis);
                m = p * b * h * l;
                Console.WriteLine("Масса выборки  =   " + m);
                Console.WriteLine("Повторить расчет\t-\tY");
                Console.WriteLine("Выйти в главное меню\t-\tN");
                Vibor = Console.ReadLine();
            }
            while (Vibor == "N");
            return 0;
        }
    }
}
