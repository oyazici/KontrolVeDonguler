using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;

namespace Ornek9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sayi Asal sayı mı
            int sayi = MyLibrary.EkrandanSayiOku("Lütfen asal sayı testine sokacağınız sayıyı giriniz: ");
            MyLibrary.AsalSayiTestiYap(sayi);
            MyLibrary.Bekle();
        }
    }
}
