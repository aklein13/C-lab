using System;
using System.Collections.Generic;
using System.Text;

namespace Figury
{
    public class Kwadrat : Wielobok
    {
        private double dlugoscBoku;
        public double DlugoscBoku
        {
            get { return dlugoscBoku; }
            set
            {
                if (value < 0)
                    throw new ApplicationException(
                    "Długość boku nie może mieć wartości ujemnej");
                dlugoscBoku = value;
            }
        }
        public Kwadrat(double dlugoscBoku, Punkt punkt, string nazwa)
: base(nazwa, 1)
        {
            DlugoscBoku = dlugoscBoku;
            this[0] = punkt;
        }
        public override Punkt this[int ktoryWierzcholek]
        {
            get
            {
                if (ktoryWierzcholek < 0 || ktoryWierzcholek > 3)
                    throw new IndexOutOfRangeException("Zły indekswierzchołka");
            switch (ktoryWierzcholek)
                {
                    case 1:
                        return new Punkt()
                        {
                            X = punkty[0].X + dlugoscBoku,
                            Y = punkty[0].Y
                        };
                    case 2:
                        return new Punkt()
                        {
                            X = punkty[0].X +
                dlugoscBoku,
                            Y = punkty[0].Y + dlugoscBoku
                        };
                    case 3:
                        return new Punkt
                        {
                            X = punkty[0].X,
                            Y = punkty[0].Y + dlugoscBoku
                        };
                }
                return punkty[0];
            }
            set
            {
                if (ktoryWierzcholek != 0)
                    throw new ApplicationException(
                    "Dla kwadratu możesz ustawić tylko początkowywierzchołek ");
                    punkty[0] = value;
            }
        }
        public sealed override double ObliczPole()
        {
            return dlugoscBoku * dlugoscBoku;
        }
        public override string Opis()
        {
            return string.Format("Kwadrat \"{0}\" o wierzchołkach w " +
            "punktach: A={1}, B={2}, C={3}, D={4}",
            Nazwa, this[0], this[1], this[2], this[3]);
        }
        public sealed override double ObliczObwod()
        {
            return 4 * dlugoscBoku;
        }
        public sealed override double WyznaczDlugoscBoku(int ktoryBok)
        {
            if (ktoryBok < 0 || ktoryBok > 3)
                throw new IndexOutOfRangeException("Zły indeks boku");
            return dlugoscBoku;
        }
        public sealed override int LiczbaWiarzcholkow
        {
            get { return 4; }
        }
    }
}
