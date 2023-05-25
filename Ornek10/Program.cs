using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;

namespace Ornek10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Üç kenar uzunluğu verilecek. Bu kenarlar ile bir üçgen oluşup oluşmayacağı belirtilecek. 
            //2 kenarın toplamı 3. kenardan büyük olur ise
            //2 kenarın farkı 3. kenardan küçük olacak. 

           int birinciKenar= MyLibrary.EkrandanSayiOku("Lütfen birinci kenarı veriniz: ");
           int ikinciKenar= MyLibrary.EkrandanSayiOku("Lütfen ikinci kenarı veriniz: ");
           int ucuncuKenar= MyLibrary.EkrandanSayiOku("Lütfen üçüncü kenarı veriniz: ");

            bool ucgenMi = MyLibrary.UcgenlikTestEt(birinciKenar,ikinciKenar,ucuncuKenar);

            if(ucgenMi)
            {
                MyLibrary.EkranaYaz("Girilen değerler ile üçgen oluşturulabilir");
            }
            else
            {
                MyLibrary.EkranaYaz("Üçgen oluşturabilmek için geçerli olmayacak değerler girdiniz.");
            }

            MyLibrary.Bekle();
        }
    }
}
