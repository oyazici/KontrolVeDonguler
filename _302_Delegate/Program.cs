using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _302_Delegate
{
    internal class Program
    {
        public delegate void GeriDonussuzParametresiz();
        
        static void Main(string[] args)
        {
            #region Anlatım
            //int a = 5;
            //GeriDonussuzParametresiz method;
            //method = Method1;
            //Method1();
            //method.Invoke();
            //method = Method2;
            //method.Invoke();

            //method += Method1; //void
            //method -= Method2;
            //method.Invoke();


            //DisKaynak.EkrandanOku ekranOkuyucu;
            //bool dataEkrandanMiOkunacak = true;
            //if (dataEkrandanMiOkunacak)
            //{
            //    ekranOkuyucu = Console.ReadLine;
            //}
            //else
            //{
            //    ekranOkuyucu = ServistenOku;
            //}

            //ekranOkuyucu.Invoke();
            #endregion

           string metin = "Alafortanfoni";
           ConsoleTasarim tasarim= Karar.KararVer(true);
           tasarim.EkranaYaz.Invoke(metin);
        }

        #region Anlatım
        //public static void Method1()
        //{
        //    //bla bla
        //}

        //public static void Method2()
        //{
        //    //bla bla
        //}

        //public static string ServistenOku()
        //{
        //    return "Alafortanfoni";
        //}

        //public string BorcSorgu(int aboneNo)
        //{
        //   return Process(aboneNo, KurumBorcSorgu);            
        //}

        //public delegate string KurumServisMethodu(int a);
        //public string Process(int aboneNo,KurumServisMethodu servisMethodu)
        //{
        //    //loglama
        //    try
        //    {
        //        return servisMethodu.Invoke(aboneNo);
        //    }
        //    catch (Exception)
        //    {
        //        //bla bla
        //        return "hata";
        //    }

        //    //loglama
        //}

        //public string KurumBorcSorgu(int aboneNo)
        //{
        //    return "alafortanfoni";
        //}


        ////borçsorgu
        ////ödeme
        ////ödemeİptal
        ////talimat ver
        ////talimat sorgula
        ////talimat iptal
        ////mutabakat
        ////detay mutabakat
        #endregion
    }

    public class ConsoleTasarim
    {
        public delegate void Abc(string a);
        public Abc EkranaYaz { get; set; }
    }

    public static class Karar
    {
        public static ConsoleTasarim KararVer(bool satirBasiOlacakMi)
        {
            ConsoleTasarim tasarim = new ConsoleTasarim();
            if(satirBasiOlacakMi)
            {
                tasarim.EkranaYaz = Console.WriteLine;
            }
            else
            {
                tasarim.EkranaYaz = Console.Write;
            }
            return tasarim;
        }
    }
}
