using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delege_event_kullanimi
{
    //void Olayyonetici delegeziituretildi
    delegate void Olayyonetici();


    class Buton
    {
        //delege üzerinden bir olay türettik burada Tikla aslında Olayyoneticisinin temsilcisi
        public event Olayyonetici Tikla;

        public void Tiklandi()
        {
            //olayyeriyonetici tektikleti olan Tıkla eventi
            Tikla();
        }



    }


    class Pencere
    {
        int a { get; set; }

        public Pencere (int a)
        {
            this.a = a;
        }


        public  void Tikla3()
        {
            Console.WriteLine("pencere sınıfındaki Tıkla3() çağırıldı");
        }

    }



    class Program
    {

        public static void Tikla1()
        {
            Console.WriteLine("program sınıfındaki Tıkla1() çağırıldı");
        }

        public static void Tikla2()
        {
            Console.WriteLine("program sınıfındaki Tıkla2() çağırıldı");
        }


        static void Main(string[] args)
        {
            Buton buton = new Buton();

            Pencere pencere = new Pencere(1), pencere1 = new Pencere(2);

            Pencere pencere2 = new Pencere(3);


            buton.Tikla += new Olayyonetici(Tikla1);
            buton.Tikla += new Olayyonetici(Tikla2);
            buton.Tikla += new Olayyonetici(pencere.Tikla3);
            buton.Tikla += new Olayyonetici(pencere.Tikla3);

            buton.Tiklandi();





        }

    }
}
