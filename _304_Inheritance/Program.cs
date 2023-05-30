using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _304_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OOP
            
            //Inheritance - base in child yerine kullanımı // kod tekrarı, merkezi kod dayatması, base-child core kodu koru
            //Encapsulation - Access Modifier
            //Polymorphism - child classlara member değiştirme izni ver (virtual-override)
            //Abstraction - kodu olmayan soyut yapılar. (Abstraction-interface)


            //Access Modifier
            //private : sadece class içi (field-method-class member)
            //internal : assembly içi (proje içi) 
            //public : heryerden (interface member zorunlu)

            //protected: kalıtım verdiğim classlardan erişilsin
            //internal protected: kalıtım verdiğim veya assembly içinden olsun. 

            //herhangi bir kuşu besle
            //Kus kus = new Kus();
            //kus.Ad = "limon";
            //kus.Uc();
            //kus.Ot();
            //kus.Beslen();

            //MuhabbetKusu muhabbetKusu = new MuhabbetKusu();
            //CekirdekKod(muhabbetKusu);
            
            Karga karga = new Karga();
            CekirdekKod(karga);

            Kus kus = new Karga();
            ICanli canli = new Karga();
            Karga karga2=(Karga)canli; //if is
            karga2.Beslen();
            Console.Read();


            //görev: enum, struct, tupple
            //static, generic, linked list ve collection, 
            //ICanli canli = new Karga();
            //Karga karga2 = (Karga)canli; //if is
            //karga2.Beslen();

            
        }

        public static void CekirdekKod(Kus kus) //parametre sayısı 5 i aşmamalı
        {
            kus.Ad = "limon";
            kus.Uc();
            kus.Ot();
            kus.Beslen();
        }


        //public static void Oldur(Karga karga)
        //{
        //    karga.Ol();
        //}

        //public static void Oldur(MuhabbetKusu muhabbetKusu)
        //{
        //    muhabbetKusu.Ol();
        //}


        //public static void Oldur(Civciv civciv)
        //{
        //    civciv.Ol();
        //}

        public static void Oldur(ICanli canli)
        {
            canli.Ol();
        }
    }

}
