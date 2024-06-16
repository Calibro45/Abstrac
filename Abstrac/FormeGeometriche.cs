using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrac
{
    public abstract class FormeGeometriche
    {
        public double Lato { get; set;  }

        public FormeGeometriche(double lato)
        {
           Lato = lato; 
        }

        public abstract double Perimetro();

        public abstract double Area();
    }
}
