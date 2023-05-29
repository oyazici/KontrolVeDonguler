using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _303_Event.Program;

namespace _303_Event
{
    public class Isveren
    {       

        public event OlayTipi IsGeldi;
        public void BasladikBilgisiVer()
        {
            Console.WriteLine("Sayın müşterimiz ürününüz için çalışmaya başladık.");
        }

        public void OrtasindayizBilgisiVer()
        {
            Console.WriteLine("Sayın müşterimiz ürününüz kısa sürede hazır olacaktır.");
        }

        public void UrununuzHazir()
        {
            Console.WriteLine("Sayın müşterimiz ürününüz hazırdır alabilirsiniz.");
        }

        public void IsDagit()
        {
            IsGeldi();
        }
    }
}
