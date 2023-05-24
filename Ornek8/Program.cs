using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;

namespace Ornek8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sayi tek mi çift mi
            int sayi = MyLibrary.EkrandanSayiOku("Lütfen bir sayı giriniz: ");
            bool ciftMi = MyLibrary.CiftMi(sayi);
            if(ciftMi)
            {
                MyLibrary.EkranaYaz("Sayi çifttir");
            }
            else
            {
                MyLibrary.EkranaYaz("Sayi tektir");
            }
            MyLibrary.Bekle();
            Main(null);
        }
    }
}
