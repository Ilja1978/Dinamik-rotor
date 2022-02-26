using System;
using System.Collections.Generic;
using System.Text;

namespace Dinamik_rotor
{
    abstract class Figure
    {
        public abstract double CalculateVolume(double d); // абстрактный метод вычисления объема
        public abstract double CalculateMass(double p, double d); // абстрактный метод вычисления массы
    }
}
