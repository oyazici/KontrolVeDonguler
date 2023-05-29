using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _303_Event
{
    public class Insan
    {
        public string Ad { get; }

        public Insan(string ad)
        {
            Ad = ad;
        }

        public delegate void GenelOlay(Insan i);

        public event GenelOlay BiriBanaVurdu;
        public event GenelOlay BiriniDovdum;
        public event GenelOlay BirineKizdim;


        public void BaskasinaVur(Insan baskasi)
        {
            Console.WriteLine("Ben {0} ve {1} kişisine vurdum", this.Ad, baskasi.Ad);
            BiriniDovdum(this);

        }

        public void DayakYe(Insan dayakAtan)
        {
            Console.WriteLine("Ben {0} ve {1} kişisi bana vurdu", this.Ad, dayakAtan.Ad);
            BiriBanaVurdu(dayakAtan);
        }

        public void BirineKiz(Insan kizilacak)
        {
            Console.WriteLine("Ben {0} ve {1} kişisine kızdım", this.Ad, kizilacak.Ad);
            BirineKizdim(kizilacak);
        }


        public void CocugumaKizma(Insan insan)
        {
            Console.WriteLine("Ben {0} ve {1} kişisi neden oğluma kızdın", this.Ad, insan.Ad);

        }

        public void TepkiVerme(Insan insan)
        {

        }
    }
}
