using System;

namespace Figury
{
    public interface IPole
    {
        double ObliczPole();
    }
    public interface IObwod
    {
        double ObliczObwod();
    }
    public abstract class FiguraPlaska
    {
        public string Nazwa { set; get; }
        protected FiguraPlaska(string nazwa)
        {
            Nazwa = nazwa;
        }
        public abstract string Opis();
    }
    public struct Punkt
    {
        public double X { set; get; }
        public double Y { set; get; }
        public override string ToString()
        {
            return string.Format("<{0}; {1}>", X, Y);
        }
    }
    public abstract class Wielobok : FiguraPlaska, IPole, IObwod
    {
        public virtual double ObliczObwod()
        {
            double suma = 0;
            for (int i = 0; i < LiczbaWiarzcholkow; i++)
            {
                suma += WyznaczDlugoscBoku(i);
            }
            return suma;
        }
        public abstract double ObliczPole();
        protected Punkt[] punkty;
        protected Wielobok(string nazwa, int liczbaWierzcholkow)
: base(nazwa)
        {
            punkty = new Punkt[liczbaWierzcholkow];
        }
        public virtual int LiczbaWiarzcholkow
        {
            get { return punkty.Length; }
        }
        public virtual Punkt this[int ktoryWierzcholek] {
get { return punkty[ktoryWierzcholek]; }
    set { punkty[ktoryWierzcholek] = value; }
}
        public virtual double WyznaczDlugoscBoku(int ktoryBok)
        {
            if (ktoryBok < 0 || ktoryBok >= LiczbaWiarzcholkow)
                throw new ArgumentException("Podałeś zły indeks bokuwieloąta");
                double x1, y1, x2, y2;
            x1 = this[(ktoryBok + 1) % LiczbaWiarzcholkow].X;
            y1 = this[(ktoryBok + 1) % LiczbaWiarzcholkow].Y;
            x2 = this[ktoryBok % LiczbaWiarzcholkow].X;
            y2 = this[ktoryBok % LiczbaWiarzcholkow].Y;
            return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 -
            y2));
        }
    }
}
