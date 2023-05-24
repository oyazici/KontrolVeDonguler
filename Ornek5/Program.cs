using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Framework;

namespace Ornek5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan okunan iki tam sayıyı karşılaştır 

            //Birinci sayiyı al
            int birinciSayi = MyLibrary.EkrandanSayiOku("Lütfen birinci sayıyı giriniz: ");
            //ikinci sayıyı al
            int ikinciSayi = MyLibrary.EkrandanSayiOku("Lütfen ikinci sayıyı giriniz: ");
            //karşılaştır
            string karsilastirmaMetni = MyLibrary.Karsilastir(birinciSayi,ikinciSayi);
            //sonucu ekrana Yaz
            MyLibrary.EkranaYaz(karsilastirmaMetni);
            //bekle
            MyLibrary.Bekle();
        }

    }
}
