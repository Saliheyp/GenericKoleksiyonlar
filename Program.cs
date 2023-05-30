using System;
using System.Collections.Generic;

namespace generic_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            // T--> object trüründedir

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("kırmızı");
            renkListesi.Add("mavi");
            renkListesi.Add("turuncu");
            renkListesi.Add("sarı");
            renkListesi.Add("yeşil");

            //Count

            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //Foreach ve List.Foreach ile elamanlara erişim
            foreach (var sayı in sayiListesi)
            {
                Console.WriteLine(sayı);
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }
            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //Liste içerisinde arama

            if (sayiListesi.Contains(10))
            {
                Console.WriteLine("10 liste içerisinde bulunuyor");
            }
            //Eleman ile indexe erişme
            
            Console.WriteLine(renkListesi.BinarySearch("turuncu"));

            //Diziyi List'e çevirme
            string[] hayvanlar = {"kedi","köpek","kuş"};
            List<string> hayvanlar2= new List<string>(hayvanlar);

            //listeyi nasıl temizleriz
            hayvanlar2.Clear();


            //Liste içerisinde nesne tutmak
            List<kullanicilar> kullaniciListesi = new List<kullanicilar>();
            kullanicilar kullanici1 = new kullanicilar();
            kullanici1.Isim = "Ayşe";
            kullanici1.Soyisim ="Yılmaz";
            kullanici1.Yas = 26;

            kullanicilar kullanici2 = new kullanicilar();
            kullanici2.Isim = "Özcan";
            kullanici2.Soyisim = "Çalışkan";
            kullanici2.Yas = 26;
            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<kullanicilar> yeniListe = new List<kullanicilar>();

            yeniListe.Add(new kullanicilar(){
                Isim = "deniz",
                Soyisim ="arda",
                Yas =24

            });
            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("kulalnici Adı:"+kullanici.Isim);
                Console.WriteLine("kulalnici Soyadı:"+kullanici.Soyisim);
                Console.WriteLine("kulalnici Yas:"+kullanici.Yas);
            }
            yeniListe.Clear();

        }
    }
    public class kullanicilar{
        string isim;
        string soyisim;
        int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
