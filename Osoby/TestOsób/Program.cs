using Osoby;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOsób
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba o1 = new Osoba("Jan", "Kowalski", 1988, Plec.Meszczyzna);
            Console.WriteLine("Utworzyłeś osobę: {0}",
            o1.ZwrocInformacje());
            Student s1 =
            new Student("Tomasz", "Nowak", 1989, Plec.Meszczyzna, 1234);
            Console.WriteLine("Utworzyłeś studenta: {0}",
            s1.ZwrocInformacje());
            Stypendysta st1 = new Stypendysta("Joanna", "Zielińska",
            1987, Plec.Kobieta, 1235, 500);
            Console.WriteLine("Utworzyłeś stypendystę: {0}",
            st1.ZwrocInformacje());
            Wykladowca w1 = new Wykladowca("Maria", "Skłodowska-Curie",
            1867, Plec.Kobieta, Wykladowca.Tytuly.prof);
            Console.WriteLine("Urworzyłeś wykładowcę: {0}",
            w1.ZwrocInformacje());
            Console.ReadKey();
        }
    }
}
