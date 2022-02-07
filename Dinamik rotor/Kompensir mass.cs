using System;
using System.Collections.Generic;
using System.Text;

namespace Dinamik_rotor
{
    class KompensirMass
    {
        private const double p = 7.82;

        
        public double Shponka(double b, double h, double l)
        {
            return p * b * h * l;
           
        }
    }
}
