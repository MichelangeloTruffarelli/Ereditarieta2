using System;

namespace Ereditarieta2
{
    public class FormaGeometrica
    {
        internal int Tipo { get; }

        public FormaGeometrica(int t)
        {
            Tipo = t;
        }

        public void CalcolaPerimetro()
        {
            if (Tipo == 1)
            {
                double CalcolcaPerimetroRettangolo(Rettangolo rettangolo)
                {
                    double p = Quadrilatero.NLatiQuadrilatero * rettangolo.Lato;
                    return p;
                }
            }
            if (Tipo == 2)
            {
                double CalcolcaPerimetroRombo(Rombo rombo)
                {
                    double p = Quadrilatero.NLatiQuadrilatero * rombo.Lato;
                    return p;
                }
            }
        }
    }
}
