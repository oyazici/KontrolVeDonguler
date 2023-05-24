using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;

namespace Ornek7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı adı ve parola karşılaştırma 

            MyLibrary.EkranaYaz("Lütfen kullanıcı adını giriniz: ");
            string userNameInput=MyLibrary.EkrandanOku();
            MyLibrary.EkranaYaz("Lütfen şifreyi giriniz: ");
            string passwordInput = MyLibrary.EkrandanOku();
            bool isTutarli = MyLibrary.KullaniciAdiVeSifreKiyasla(userNameInput, passwordInput);

        }
    }
}
