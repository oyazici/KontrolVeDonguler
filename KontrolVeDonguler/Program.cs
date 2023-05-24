using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolVeDonguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // //Oparatör
           // //= sağdan sola atama
           // //==  
           // //+
           // //!=
           // //>
           // //<
           // //>=
           // //<=
           // //+=
           // //-=
           // //*=
           // ///=
           // //++
           // //--
           // //%
           // // &&
           // // ||
           // // &
           // // |
           // int sayi = 5;
           // sayi = sayi + 5;
           // sayi += 5;
           // sayi = 100 % 4;

           // bool buyukMu = sayi > 5 && sayi < 0;  //false arıyor bulamaz ise true dönüyor

           // //buyukMu = method1() || methot2();      //true arıyor bulamaz ise false dönüyor. 

           //// YemekHazırMi = MehmetYemekYap() & AhmetSalatayıYap();

           // //If Else 
           // if(kosul)
           // {
              
           // }
           // else
           // {
           //     //bla bla
           // }

           // if (kosul)
           // {
           //     //bla bla
           // }
           // else if(kosul2)
           // {

           // }
           // else if (kosul3)
           // {

           // }
           // else
           // {
           //     //bla bla
           // }

           // for (int i = 0; i < length; i++)
           // {

           // }

           // int i = 5;
           // int length = 20;
           // for (;i < length;)
           // {

           //     i++;
           // }

           // //return,continue,break

           // int i = 5;
           // int length = 20;
           // for (;true;)
           // {
                
           //     i++;
           //     if(i<length)
           //     {
           //         break;
           //     }
           // }

           // while (i < length)
           // {
           //     i++;
               
           // }

            //hangi durum da hangisi kullanılacak.


            //Array (referans type)
            int[] sayilar = new int[5];
            sayilar[0] = 5;
            sayilar[1] = 4;
            sayilar[2] = 23;
            sayilar[3] = 45;
            sayilar[4] = 56;
            sayilar[5] = 67; //hata

            int[] sayilar2 = { 4, 66, 324, 234 };
            int[] tempSayilar = new int[3];

            for (int i = 0; i < tempSayilar.Length; i++)
            {
                tempSayilar[i]= sayilar2[i];
            }
            sayilar2 = tempSayilar;
            //referans ataması


            //özellik bulma
            //3 tip yakalama
            // 1- tipi üzerinden
            int a;
            int.Parse("5");
              //  2- değişken üzerinden
               // a.CompareTo(4);
                //3- harici (external,dıs kütüphane)
                Math.Max(5, 7);

            string ad = "osman";
            string.Format("Toplama işleminin sonucu {0}", 56);
            string.Format("ilgili kişinin adı:{0} soyadı:{1} ve yaşı {2} dır. ", ad, "Yazıcı", 40);

            DateTime date = new DateTime(2023, 5, 23);

           date= date.AddDays(3);
          DayOfWeek haftaninGunu=  date.DayOfWeek;




        }
    }
}
