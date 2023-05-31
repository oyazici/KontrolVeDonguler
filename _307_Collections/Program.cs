using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _307_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 35;
            //Node head = new Node();
            //Node node1 = new Node();
            //head.Next = node1;

            //Node node2 = new Node();
            //node1.Next = node2;
            SiraOgesi head = new SiraOgesi();
            SiraOgesi oge1 = new SiraOgesi();
            head.Sonraki = oge1;
            //int[] sayilar = new int[5]();
            //sayilar[0] = 4;
                
            foreach (var siradaki in head)
            {

            }
            //Array

            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add("osman");
            //list.Add(head);



            List<int> sayilar = new List<int>();
            sayilar.Add(1);
            sayilar.Add(1);

            //linq
            List<int> result = (from sayi4 in sayilar 
                              where sayi4 == 1
                                select sayi4).ToList();

            //lamda
            List<int> filtrelenmisSayilar= sayilar.Where(x=> x==1).ToList();
            bool varMi=  sayilar.Any(x=> x==1);
            Func<int, bool> method = x =>  x == 1;
            sayilar.Where(method).ToList();
            method.Invoke(5);

           int sayi2= sayilar[0];
            Queue<string> bankaSirasi = new Queue<string>(); //ilk giren son çıkar
            bankaSirasi.Enqueue("osman");
            bankaSirasi.Enqueue("Sertaç");
            bankaSirasi.Enqueue("Hamdi");

            bankaSirasi.Peek();

            //Stack<int> son giren ilk çıkar
            //HashSet<int> değerleri unique olarak saklar

            Dictionary<string, string> insan = new Dictionary<string, string>();
           
            insan.Add("ad", "osman");
            insan.Add("soyad", "yazıcı");
            insan.Add("yas", "1");

           string ad= insan["ad"];

            //görevler linq-lamda incelemesi 
            
            //yarın işlenecekler
            //isimlendirme unutmayalım. 
            //immutable
            //Ado.Net
            //ntier
        }

        public void IslemYap(IList liste)
        {
            
        }
    }
   //IEnumerable
   //ICollection
  //ICollection<int>
  //IList<int>
  //IDictionary<string,string>


    //IQueryable 
    class Node
    {
        public Node Next;
    }

    class SiraOgesi : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            Siramatik siramatik=new Siramatik(this);
            return siramatik;
        }

        public SiraOgesi Sonraki { get; set; }
    }

    class Siramatik : IEnumerator
    {
        private SiraOgesi head;
        private SiraOgesi current;
        public Siramatik(SiraOgesi head)
        {
            this.head = head;
            this.current = head;
        }
        public object Current => current;

        public bool MoveNext()
        {
            current = current.Sonraki;
            if(current==null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Reset()
        {
            current = head;
        }
    }

    class SiraOgesi2 : IEnumerable<SiraOgesi2>
    {
        public IEnumerator<SiraOgesi2> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    class Siramatik2 : IEnumerator<SiraOgesi2>
    {
        public SiraOgesi2 Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
