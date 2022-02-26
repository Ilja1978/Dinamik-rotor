using System;
using System.Collections.Generic;
using System.Text;

namespace Dinamik_rotor
{
    abstract class Weight // класc высщитывающий вес объекта
    {
        private double pi = Math.PI;
        double m, V;
        public double Circl(double p, double d) // Вычисляем массу круга
        {
            return m;
        }
        public double Circle(double d) // Вычисляем объем круга
        {
            return V;
        }
        public double Rectangle(double p, double b, double h, double l) // масса прямоугольника (ширина х высота х длинна)
        {
            m = p * b * h * l;
            return m;
        }
        public double Rectangle(double b, double h, double l) // Объем прямоугольника (ширина х высота х длинна)
        {
            return V;
        }
    }
}