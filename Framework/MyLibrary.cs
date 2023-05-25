using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Framework
{
    public class MyLibrary
    {
        public static void Bekle()
        {
            Console.ReadKey();
        }

        public static void EkranaYaz(string karsilastirmaMetni)
        {
            Console.Write(karsilastirmaMetni);
        }

        public static void AsalSayiTestiYap(int sayi)
        {
            bool asalSayiMi = true;
            if (sayi > 2)
            {
                for (int i = 2; i < (sayi / 2 + 1); i++)
                {
                    if (sayi % i == 0)
                    {
                        asalSayiMi = false;
                        break;
                    }
                }
            }
            else
            {
                asalSayiMi = false;
            }

            if (asalSayiMi)
            {
                EkranaYaz("Girilen sayı asalsayıdır");
            }
            else
            {
                EkranaYaz("Girilen sayı asal sayı değildir.");
            }
        }

        public static bool UcgenlikTestEt(int birinciKenar, int ikinciKenar, int ucuncuKenar)
        {
            //if(birinciKenar+ikinciKenar>ucuncuKenar)
            //{
            //    if(birinciKenar+ucuncuKenar>ikinciKenar)
            //    {
            //        if(ikinciKenar+ucuncuKenar>birinciKenar)
            //        {

            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //else
            //{
            //    return false;
            //}

            //2 kenarın toplamı 3. kenardan büyük olur ise
            //2 kenarın farkı 3. kenardan küçük olacak. 
            //bunu sağlayabilmek için kenarlar arasında 6 adet şartın sağlanması lazım. 
            bool sart1 = (birinciKenar + ikinciKenar > ucuncuKenar);
            bool sart2 = (birinciKenar + ucuncuKenar > ikinciKenar);
            bool sart3 = (ucuncuKenar + ikinciKenar > birinciKenar);
            bool sart4 = (Math.Abs(ucuncuKenar - ikinciKenar) < birinciKenar);
            bool sart5 = (Math.Abs(birinciKenar - ikinciKenar) < ucuncuKenar);
            bool sart6 = (Math.Abs(birinciKenar - ucuncuKenar) < ikinciKenar);

            //bu şartlardan herhangi biri sağlanamaz ise üçgen oluşmayacağından false dönülür 

            if (!sart1 || !sart2 || !sart3 || !sart4 || !sart5 || !sart6)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public static bool CiftMi(int sayi)
        {
            bool ciftMi = false;
            if (sayi % 2 == 0)
            {
                ciftMi = true;
            }
            return ciftMi;
        }

        public static string Karsilastir(int birinciSayi, int ikinciSayi)
        {
            if (birinciSayi > ikinciSayi)
            {
                return "Birinci sayı ikinci sayıdan büyüktür";
            }
            else if (ikinciSayi > birinciSayi)
            {
                return "İkinci sayı birinci sayıdan büyüktür";
            }
            else
            {
                return "sayılar eşittir";
            }
        }

        public static bool KullaniciAdiVeSifreKiyasla(string userNameInput, string passwordInput)
        {
            string userName = "osman";
            string password = "alafortanfoni";
            throw new NotImplementedException();
        }

        public static string Karsilastir(string birinci, string ikinci)
        {
            if (birinci == ikinci)
            {
                return "ifadeler eşittir";
            }
            else
            {
                return "ifadeler eşit değildir";
            }

        }

        public static int EkrandanSayiOku(string ekranMesaji)
        {
            //karşılamayı yaz
            EkranaYaz(ekranMesaji);
            //ekrandan değer oku
            string input = EkrandanOku();

            //değeri sayıya çevir
            int sayi;
            bool donustuMu = SayiyaDonustuMu(input, out sayi);
            //değeri dön. 
            if (donustuMu)
            {
                return sayi;
            }
            else
            {
                EkranaYaz("hatalı giriş yapıldı");
                BirSureBekle(5000);
                EkraniTemizle();
                return EkrandanSayiOku(ekranMesaji);
            }
        }

        public static void EkraniTemizle()
        {
            Console.Clear();
        }

        public static void BirSureBekle(int milisaniye)
        {
            Thread.Sleep(milisaniye);
        }

        public static string EkrandanOku()
        {
            return Console.ReadLine();
        }

        public static bool SayiyaDonustuMu(string input, out int sayi)
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
                return false;
            }
        }
    }
}
