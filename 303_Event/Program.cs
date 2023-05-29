using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _303_Event
{
    public class Program
    {
        public delegate void OlayTipi();
        static void Main(string[] args)
        {
            //tepki,duygu,olay....

            //tanımlar
            //senaryo



            //Insan pasa = new Insan("Paşa");
            //Insan mustafa = new Insan("Mustafa");
            //Insan fatih = new Insan("fatih");
            //Insan taner = new Insan("taner");
            //Insan osman = new Insan("Osman");
            //Insan baba = new Insan("baba");

            ////senaryo
            //pasa.BiriniDovdum += mustafa.DayakYe;
            //pasa.BiriniDovdum += taner.DayakYe;
            //pasa.BiriniDovdum += fatih.DayakYe;
            //mustafa.BiriBanaVurdu += osman.BirineKiz;
            //taner.BiriBanaVurdu += osman.BirineKiz;
            //fatih.BiriBanaVurdu+= osman.BirineKiz;
            //osman.BirineKizdim += baba.CocugumaKizma;


            //pasa.BaskasinaVur(mustafa);

            //pasa.BaskasinaVur(mustafa);
            //mustafa.DayakYe(pasa);
            //osman.BirineKiz(pasa);


            Isveren isveren = new Isveren();
            
            Isci[] isciler = new Isci[40];
            for (int i = 0; i < isciler.Length; i++)
            {
                isciler[i] = new Isci(i + 1);
                isveren.IsGeldi += isciler[i].Calis;

               isciler[i].IseBasladim += isveren.BasladikBilgisiVer;
               // isciler[i].IsinOrtasindayim += isveren.OrtasindayizBilgisiVer;
                isciler[i].IsiBitirdim += isveren.UrununuzHazir;
            }


            isveren.IsDagit();




            Console.Read();
        }
    }
}
