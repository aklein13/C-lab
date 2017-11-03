using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instrumenty
{
    class Fabryka
    {
        public static Instrument Utworz(int i)
        {
            Instrument instr = null;
            switch (i)
            {
                case 1:
                    instr = new Instrument();
                    break;
                case 2:
                    instr = new Trabka();
                    break;
            }
            return instr;
        }
        public static int Menu()
        {
            Console.Clear();
            Console.WriteLine("\n\t\t\t1 - Informacje ogólne o instrumenta");
Console.WriteLine("\n\t\t\t2 - Informacje o trąbce");
            Console.WriteLine("\n\t\t\t0 - Koniec");
            int i;
            bool b;
            do
            {
                do
                {
                    b = int.TryParse(Console.ReadLine(), out i);
                } while (!b);
            } while (
            0
            >
            i
            || i
            >
            2);
            return i;
        }
    }
}
