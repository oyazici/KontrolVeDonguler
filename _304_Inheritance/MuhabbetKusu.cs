using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _304_Inheritance
{
    internal class MuhabbetKusu :Kus,ICanli
    {
        public override void Ot()
        {
            Console.WriteLine("babacık, cici kuş");
        }
        public override void Beslen()
        {
            string verilen = Console.ReadLine();
            if (verilen == "yem" || verilen == "meyve")
            {
                Console.WriteLine("yedim");
            }
        }

        public override void Uc()
        {
            //bla bla
        }

        public void Ol()
        {
            //bla bla
        }
    }
}
