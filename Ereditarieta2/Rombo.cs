using System;
using System.Collections.Generic;
using System.Text;

namespace Ereditarieta2
{
    public class Rombo : Quadrilatero
    {
        internal double Lato { get; }

        public Rombo(double l)
        {
            Lato = l;
        }
    }
}
