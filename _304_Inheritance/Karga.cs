using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _304_Inheritance
{
    internal class Karga:Kus,ICanli
    {
        public override void Beslen()
        {
            string verilen = Console.ReadLine();
            if (verilen == "yem" || verilen == "herhangi gıda")
            {
                Console.WriteLine("yedim");
            }
            else
            {
                base.Beslen();
            }
        }

        public void Ol()
        {
            //bla bla
        }

        public override void Ot()
        {
            Console.WriteLine("Gak Gaaaaak");
        }

        public override void Uc()
        {
            //bla bla
        }
    }
}
