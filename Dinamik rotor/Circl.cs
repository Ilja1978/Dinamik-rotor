using System;
using System.Collections.Generic;
using System.Text;

namespace Dinamik_rotor
{
    class Circl : Figure
    {
        private const double pi = Math.PI;
        private double m, V;
        public override double CalculateVolume(double d) // абстрактный метод вычисления объема
        {
            return V;
        }
        public override double CalculateMass(double p, double d) // абстрактный метод вычисления массы
        {
            return m;
        }
    }
}
