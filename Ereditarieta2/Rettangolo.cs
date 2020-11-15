using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarieta2
{
    public class Rettangolo : Quadrilatero
    {
        public double Lato { get; }

        public Rettangolo(double l)
        {
            Lato = l;
        }
    }
}
