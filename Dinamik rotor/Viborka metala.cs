using System;
using System.Collections.Generic;
using System.Text;

namespace Dinamik_rotor
{
    class Viborka_metala
    {
        private double m, b, h, l;
        private const double p = 7.82;
        string Vibor;
        public double Lineino()
        {
            do
            {
                Console.Write("Введите массу\t");
                string Mas = Console.ReadLine();
                m = Convert.ToDouble(Mas);
                Console.Write("Введите ширину\t");
                string Shir = Console.ReadLine();
                b = Convert.ToDouble(Shir);
                Console.Write("Введите высоту \t");
                string Vis = Console.ReadLine();
                h = Convert.ToDouble(Vis);
                l = m / (p * b * h);
                Console.WriteLine("Длинна выборки\t = \t" + l);
                Console.WriteLine("Масса выборки  =   " + m);
                Console.WriteLine("Повторить расчет\t-\tY");
                Console.WriteLine("Выйти в главное меню\t-\tN");
                Vibor = Console.ReadLine();
            }
            while (Vibor=="N");
            return 0;
        }
    }
}
