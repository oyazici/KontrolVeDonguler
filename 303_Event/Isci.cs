using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static _303_Event.Program;

namespace _303_Event
{
    public class Isci
    {
        public Isci(int sicil)
        {
            Sicil = sicil;
        }
        public int Sicil { get; set; }
        public event OlayTipi IseBasladim;
        public event OlayTipi IsinOrtasindayim;
        public event OlayTipi IsiBitirdim;
        public void Calis()
        {
            Console.WriteLine("{0}. sicildeki personelim işe başladım",Sicil);
            IseBasladim();
            Thread.Sleep(5000);
            Console.WriteLine("{0}. sicildeki personelim işin ortasındayım", Sicil);
            IsinOrtasindayim();
            Thread.Sleep(5000);
            Console.WriteLine("{0}. sicildeki personelim işi bitirdim", Sicil);
            IsiBitirdim();

        }
    }
}
