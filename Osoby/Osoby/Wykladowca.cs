using System;
using System.Collections.Generic;
using System.Text;

namespace Osoby
{
   
    public class Wykladowca : Osoba
    {
        public enum Tytuly { dr, dr_hab, prof }
        public Tytuly Tytul { set; get; }
        public Wykladowca(string imie, string nazwisko, int rokUrodzenia,
Plec plec, Tytuly tytul)
: base(imie, nazwisko, rokUrodzenia, plec)
        {
            Tytul = tytul;
        }
        private string zwrocTytul()
        {
            string tytul = "";
            switch (Tytul)
            {
                case Tytuly.dr: tytul = "dr"; break;
                case Tytuly.dr_hab: tytul = "dr hab."; break;
                case Tytuly.prof: tytul = "prof."; break;
            }
            return tytul;
        }
        public new string ZwrocInformacje()
        {
            if (Plec == Plec.Kobieta)
                return string.Format("Pani {3} {0} {1} urodzona w {2}",
                Imie, Nazwisko, RokUrodzenia, zwrocTytul());
            return string.Format("Pan {3} {0} {1} urodzony w {2}",
            Imie, Nazwisko, RokUrodzenia, zwrocTytul());
        }
    }
}
