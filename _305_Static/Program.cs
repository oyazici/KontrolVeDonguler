using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _305_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static: instance yada heape çık emri vermeden runtime sırasında belleğe çıkar. Tekilleşir, objeden bağımsız hale getirir. Class ismi ile erişilebilir. 

            Insan insan = new Insan();
            Insan insan2 = new Insan();
            Console.WriteLine(Insan.Nufus);
            Insan insan3 = new Insan();
            Insan insan4 = new Insan();
            Console.WriteLine(Insan.Nufus);
            Console.Read();

            int karesiAlinacak = 5;
            Framework.Topla(5, 6);
            int sonuc = Framework.Karesi(karesiAlinacak);
            sonuc = karesiAlinacak.Karesi();

            sonuc.Topla(5, 6);

            var cb = CumhurBaskani.CumhurBaskanim;
            cb.Yonet();

            var cb2 = CumhurBaskani.CumhurBaskanim;
            cb2.Yonet();

            var cb3 = CumhurBaskani.Instance();
            cb3.Yonet();
        }
    }

    public class Insan
    {
        public static int Nufus { get; private set; }

        public Insan()
        {
            Nufus++;
        }

        ~Insan()
        {
            Nufus--;
        }

        //ortak yaptığımız ve hiç değişmeyen nesneye özel değerler taşımayacak işlemler tekrar tekrar rame çıkmasın diye de static işaretlenir. 


    }

    public static class Framework
    {
        public static int Topla(int a, int b)
        {
            return a + b;
        }

        public static int Karesi(this int a)
        {
            return a * a;
        }

        public static void Topla(this ref int a, int b, int c)
        {
            a = a + b + c;
        }
    }

    public class CumhurBaskani  //Singleton
    {
        private static CumhurBaskani cumhurBaskani;
        private CumhurBaskani()
        {

        }

        public static CumhurBaskani CumhurBaskanim
        {
            get
            {
                if (cumhurBaskani == null)
                {
                    cumhurBaskani = new CumhurBaskani();
                }
                return cumhurBaskani;
            }
        }


        public static CumhurBaskani Instance()
        {

            if (cumhurBaskani == null)
            {
                cumhurBaskani = new CumhurBaskani();
            }
            return cumhurBaskani;

        }

        public void Yonet() { }
    }

}
