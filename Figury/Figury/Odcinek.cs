using System;
using System.Collections.Generic;
using System.Text;

namespace Figury
{
    public class Odcinek : FiguraPlaska
    {
        public Punkt A { set; get; }
        public Punkt B { set; get; }
        public Odcinek(Punkt poczatek, Punkt koniec, string nazwa)
: base(nazwa)
        {
            A = poczatek;
            B = koniec;
        }
        public override string Opis()
        {
            return string.Format("Punkt \"{0}\" o początku {1} i końcu{2} ",Nazwa,A,B) ;
        }
    }
}
