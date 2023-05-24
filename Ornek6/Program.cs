using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;

namespace Ornek6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan okunan iki karakteri karşılaştırma 
            //Ekrandan birinciyi oku
            MyLibrary.EkranaYaz("Lütfen birinci ifadeyi giriniz: ");
            string birinci = MyLibrary.EkrandanOku();
            //Ekrandan ikinciyi oku
            MyLibrary.EkranaYaz("Lütfen ikinci ifadeyi giriniz: ");
            string ikinci = MyLibrary.EkrandanOku();
            //karşılaştır (eşit/değil)
            string mesaj = MyLibrary.Karsilastir(birinci, ikinci);
            //ekrana yaz
            MyLibrary.EkranaYaz(mesaj);
            //bekle
            MyLibrary.Bekle();
        }
    }
}
