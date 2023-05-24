using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ornek3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan öncelikle kaç sayının alınacağını oku sonrasında sayıları tek tek ekrandan alıp topla. 
            int sayiAdeti=0;
            string input;
            bool donustuMu=false;
            while (!donustuMu)
            {
                Console.Write("Kaç adet sayı için işlem yapmak istersiniz:");
                input = Console.ReadLine();
                if(input=="exit")
                {
                    Environment.Exit(0);
                }
               
                donustuMu = int.TryParse(input, out sayiAdeti);
                if (!donustuMu)
                {
                    Console.WriteLine("Sayi adetini girerken hatalı giriş yaptınız.");
                    Thread.Sleep(5000);
                    Console.Clear();
                    continue;
                }
            }


            int[] sayilar = new int[sayiAdeti];

            for (int i = 0; i < sayiAdeti; i++)
            {
                donustuMu = false;
                while (!donustuMu)
                {
                    Console.Write("Lütfen {0}. sayıyı giriniz", i + 1);
                    input = Console.ReadLine();
                    if (input == "exit")
                    {
                        Environment.Exit(0);
                    }
                    int sayi;
                    donustuMu = int.TryParse(input, out sayi);
                    if (!donustuMu)
                    {
                        Console.WriteLine("{0}. sayıyı girerken hata yaptınız.", i + 1);
                        Thread.Sleep(5000);
                        Console.Clear();
                        continue;
                    }
                    sayilar[i] = sayi;
                }
            }

            long toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += (long)sayilar[i];
            }

            Console.WriteLine("Sayıların toplamı:" + toplam+" dır");
            //Console.WriteLine("Sayıların toplamı:{0} dır" , toplam);
            Console.Read();
            System.Ornek.Alafortanfoni.Kod();
        }


        //Math, String, ve Date methodlarını inceliyorsunuz. Çok kullanılanları örneklendirin. 
        //Ekrandan okunan iki tam sayıyı karşılaştırma 
        //Ekrandan okunan iki karakteri karşılaştırma 
        //Kullanıcı adı ve parola karşılaştırma 
        //Sayi tek mi çift mi
        //sayi Asal sayı mı
        //Üç kenar uzunluğu verilecek. Bu kenarlar ile bir üçgen oluşup oluşmayacağı belirtilecek. 
        //Çok sayı girişi yapılacak ve sayılardan en küçüğü bulunacak. 
        //Girilen sayı dizisinin büyükten küçüğe sıralanması sağlanmalı


        //Prosedürel programlama - Fonksiyonel Programlama. (yarın) //random


    }
}
