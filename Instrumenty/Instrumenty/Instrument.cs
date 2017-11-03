using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instrumenty
{
    class Instrument
    {
        public virtual void Graj()
        {
            Console.WriteLine("Instrumenty wydają dźwięki o różnej " +
            "częstotliwości i barwie...");
        }
        public virtual string Opis
        {
            get
            {
                return "Instrument muzyczny - przyrząd wytwarzający dźwięk";
            }
        }
        public override string ToString()
        {
            return "instrument";
        }
    }
}
