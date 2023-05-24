using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan okunan iki tamsayının toplamı

            Console.Write("Lütfen birinci sayıyı giriniz:");
            string input=Console.ReadLine();
            int sayi1;
            bool donustuMu = int.TryParse(input, out sayi1);

            if(!donustuMu)
            {
                Console.WriteLine("Birinci sayı için hatalı giriş yaptınız");
                Console.Read();
                Environment.Exit(0);
            }

            Console.Write("Lütfen ikinci sayıyı giriniz:");
            input = Console.ReadLine();
            int sayi2;
            donustuMu = int.TryParse(input, out sayi2);

            if (!donustuMu)
            {
                Console.WriteLine("İkinci sayı için hatalı giriş yaptınız");
                Console.Read(); 
                Environment.Exit(0);
            }

            long toplam = (long)sayi1 + sayi2;
            Console.WriteLine("Toplama işleminin sonucu:{0}", toplam);
            Console.Read();

        }


        public void Islem()
        {
            Console.Write("Lütfen birinci sayıyı giriniz:");
            string input = Console.ReadLine();
            int sayi1;
            bool donustuMu = int.TryParse(input, out sayi1);

            if (donustuMu)
            {
                Console.Write("Lütfen ikinci sayıyı giriniz:");
                input = Console.ReadLine();
                int sayi2;
                donustuMu = int.TryParse(input, out sayi2);

                if (donustuMu)
                {

                    long toplam = (long)sayi1 + sayi2;
                    Console.WriteLine("Toplama işleminin sonucu:{0}", toplam);
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("İkinci sayı için hatalı giriş yaptınız");
                    Console.Read();
                    Environment.Exit(0);
                }

            }
            else
            {
                Console.WriteLine("Birinci sayı için hatalı giriş yaptınız");
                Console.Read();
                Environment.Exit(0);
            }
        }
    }
}
