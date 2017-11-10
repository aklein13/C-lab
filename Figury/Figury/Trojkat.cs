using System;
using System.Collections.Generic;
using System.Text;

namespace Figury
{
    public class Trojkat : Wielobok
    {
        public Trojkat(string nazwa) : base(nazwa, 3)
        {
        }
        public Trojkat(string nazwa, Punkt[] wierzcholki)
: base(nazwa, 3)
        {
            for (int i = 0; i < 3; i++)
            {
                this[i] = wierzcholki[i];
            }
        }
        public sealed override double ObliczPole()
        {
            double a = WyznaczDlugoscBoku(0);
            double b = WyznaczDlugoscBoku(1);
            double c = WyznaczDlugoscBoku(2);
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public override string Opis()
        {
            return string.Format("Trojkąt \"{0}\" o wierzchołkach w " + "punktach: A={1}, B={2}, C={3}",
            Nazwa, this[0], this[1], this[2]); ;
        }
        public sealed override double WyznaczDlugoscBoku(int ktoryBok)
        {
            return base.WyznaczDlugoscBoku(ktoryBok);
        }
        public sealed override double ObliczObwod()
        {
            return base.ObliczObwod();
        }
    }
}
