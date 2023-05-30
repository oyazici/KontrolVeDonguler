using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _304_Inheritance
{
    internal abstract class Kus //abstract class
    {
        private string ad;
        public string Ad { get { return ad; } set { ad = value; } }

        public Kus()
        {
            //while (true)
            //{
            //    NefesAl();
            //}
        }

        private void NefesAl()
        {
            //bla bla
        }

        public abstract void Uc(); //abstract method




        public virtual void Ot()
        {
            Console.WriteLine("cik cik");
        }

        public virtual void Beslen()
        {
            string verilen = Console.ReadLine();
            if (verilen == "yem")
            {
                Console.WriteLine("yedim");
            }
        }


    }
}
