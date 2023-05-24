using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek4
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Ekrandan okunan iki tam sayıyı karşılaştırma 

            //Hakim Yazılımcı - Maliyet
            //Ekip
            //Hata ihtimali çok yüksek (kırılganlık)
            //yeniden kullanılabilirlik
            //bakım maliyeti
            //modüler

            //Yürü
            //Yemek yap

            //Emir ver..... (algoritmaya uygun)
            int sayi2;
           bool donustuMu= SayiyaDonustuMu("5", out sayi2);
            if(donustuMu)
            {
                Console.WriteLine("Tamam");
            }
            else
            {
                Console.WriteLine("hata");
            }
            Console.Read();

        }


        //public static TipBilgisi MethodAdi(tip parametreAdi,tip parametreadi....) 
        //{
        //    //bla bla

        //    return;
        //    return TipBilgisi;
        //}

        //Geridönüşlü parametreli method.
        //public static int Topla(int sayi1,int sayi2)
        //{
        //    int toplam;
        //    toplam = sayi1 + sayi2;
        //    return toplam;
        //}

        //Geridönüşlü parametresiz method.
        public static double PISayisiniVer()
        {
            return Math.PI;
        }

        //GeriDonussuz parametreli method.
        public static void EkranaYaz(string metin)
        {
            if(string.IsNullOrWhiteSpace(metin))
            {
                return;
            }
            Console.Write(metin);
        }

        //GeriDonussuz parametresiz method.
        public static void Kapat()
        {
            Environment.Exit(0);
        }


        //method overloading
        //public static int Topla(int sayi1, int sayi2,int sayi3)
        //{
        //    int toplam;
        //    toplam = sayi1 + sayi2 + sayi3;
        //    return toplam;
        //}

        //public static int Topla(int sayi1, int sayi2, int sayi3, int sayi4)
        //{
        //    int toplam;
        //    toplam = sayi1 + sayi2 + sayi3 + sayi4;
        //    return toplam;
        //}

        ////
        //public static int Topla(int sayi1, int sayi2, int sayi3)
        //{
        //    int toplam;
        //    toplam =Topla(sayi1,sayi2) + sayi3;
        //    return toplam;
        //}

        //public static int Topla(int[] sayilar)
        //{
        //    int toplam=0;
        //    for (int i = 0; i < sayilar.Length; i++)
        //    {
        //        toplam += sayilar[i];
        //    }
        //    return toplam;
        //}


        public static int Topla(params int[] sayilar)
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            return toplam;
        }

        //public static int Faktoryel(int sayi)
        //{
        //    int carpim = 1;
        //    for (int i = 1; i <= sayi; i++)
        //    {
        //        carpim *= i;
        //    }
        //    return carpim;
        //}
        //7! = 7 * 6!

        //recursive method
        public static int Faktoryel(int sayi)
        {      
            if(sayi<=1)
            {
                return 1;
            }
            return sayi * Faktoryel(sayi - 1);
        }

        //int sayi=0;
        public static bool SayiyaDonustuMu(string input,out int sayi)
        {
            sayi = 0;
            try
            {
                sayi = int.Parse(input);
                //bağlantıyı kapat;
                return true;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
            catch (NullReferenceException ex)
            {
                return false;
            }
            catch(Exception ex)
            {
                throw;
                throw ex;
                throw new Exception("Sayi girişinde hata oldu", ex);
            }
            finally
            {
                //bağlantıyı kapat;
            }

            //out = içerideki parametrenin referans adresini dışarıdaki değişkene verir.
            //ref = dışarıdaki değikenin referans değerini içerideki parametreye verir. 
        }


        //hata türleri
        //1- Derleme Hataları (error list)
        //2- Runtime hataları (Exception - Try/Catch)
        //3- Mantık hataları  (Rubber Duck Debugging - Refactor) 

        //breakpoint - kaydırma
        //watch/quickwatch/breakpoints/immediate
    }
}
