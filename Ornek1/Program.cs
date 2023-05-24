using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen değerin tamsayı tipinde bir değişkene atanması
            char[] karakterler = { 'A', 'B', 'C' };


            Console.Write("Lütfen bir sayı giriniz: ");
             string input= Console.ReadLine();

            for (int i = 0; i < karakterler.Length; i++)
            {
                if(input.Contains(karakterler[0]))
                {
                    Console.Write("Harf girişi yapıldığı için işlem yapılamamıştır. ");
                    Console.Read();
                    Environment.Exit(0); //return;
                }
            }


            if(input=="" )
            {
                Console.Write("Boş giriş yapıldığı için işlem yapılamamıştır. ");
                Console.Read();
            }
            else
            {
                int sayi = Convert.ToInt32(input);
                Console.Write("Atama gerçekleşti");
                Console.Read();
            }
        }

        public void Islem()
        {
            Console.Write("Lütfen bir sayı giriniz: ");
            string input = Console.ReadLine();
            int sayi;
            bool donustuMu = int.TryParse(input, out sayi);
            if(donustuMu)
            {
                Console.Write("Atama gerçekleşti");
            }
            else
            {
                Console.Write("Atama sırasında hata oldu. Atama gerçekleşmedi.");
            }
        }
    }


}
