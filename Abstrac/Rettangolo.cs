﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrac
{
    public class Rettangolo : FormeGeometriche
    {
        public double Altezza { get; set; }

        public Rettangolo(double b, double h) : base(b)
        {
            Lato = b;
            Altezza = h;
        }

        public override double Perimetro()
        {
            var perimetro = (Lato + Altezza) * 2;
            return perimetro;
        }

        public override double Area()
        {
            var area = Lato * Altezza;
            return area;
        }
    }
}
