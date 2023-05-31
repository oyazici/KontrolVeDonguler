using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _306_Generic
{
    internal class Program
    {

       // public delegate int ToplamaTipi(int input);

       //public delegate Tout Func<in Tin, out Tout>(Tin input);

       // public ToplamaTipi Topla;

        //public DelegateTipi<int,int> Topla;
        //public Func<int, int> Topla;
      //  Func<>
     // Action<>
    //Predicate<int>


        public void IslemYap(int a,Func<int,int> method)
        {
            //loglama
            try
            {
                method.Invoke(a);
            }
            catch (Exception)
            {

                //hata
            }
            //loglama
        }
        static void Main(string[] args)
        {
            //cast maliyeti
            //boxing - unboxing
            //objeye atanacakların bir sınırı - kısıtı olmaması sorunu

            //EkranaYaz<string>("Alafortanfoni");
            EkranaYaz<int>(5);
            EkranaYaz<long>(5);

            Insan<int> insan = new Insan<int>();
        }

        //public static void EkranaYaz(string metin)
        //{
        //    Console.WriteLine(metin);
        //}

        //public static void EkranaYaz(int sayi)
        //{
        //    Console.WriteLine(sayi);
        //}

        //public static void EkranaYaz(long sayi)
        //{
        //    Console.WriteLine(sayi);
        //}

        public static void EkranaYaz(object obj)
        {
            Console.WriteLine(obj);
        }

        public static void EkranaYaz<T>(T input) where T:struct
        {
            Console.WriteLine(input);
        }

        public static void EkranaYaz1<T>(T input) where T : class
        {
            Console.WriteLine(input);
        }

        public static void EkranaYaz2<T>(T input) where T : class,ICanli
        {
            Console.WriteLine(input);
        }

        public static void EkranaYaz3<T>(T input) where T : Kus,ICanli,new()
        {
            T degisken = new T();
            Console.WriteLine(input);
        }

        //public static Tout Topla<Tin,Tout>(Tin input)
        //    {

        //    }

    }

    interface ICanli
    {

    }

    class Kus
    {

    }

    class Insan<T> where T:struct
    {
        public void Islem<T>(T input)
        {

        }
    }
}
