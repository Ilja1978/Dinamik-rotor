using System;
using System.Collections.Generic;
using System.Text;

namespace Dinamik_rotor
{
    class MetalSampling 
    {
        //private double m, b, h, l;
        private const double p = 7.82;
        //string Choice; // Выбор действия
        public double LinearSampling(double m, double b, double h)
        {
            
            return  m / (p * b * h); 
        }

        
    }
}

