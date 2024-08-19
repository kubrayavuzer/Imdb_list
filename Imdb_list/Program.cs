using System;
using System.Collections.Generic;
class Film
{
    public class film
    {
        public string Isim { get; set; }
        public double Puan { get; set; }

        public film (string isim, double puan)
        {
            Isim = isim;
            Puan = puan;
        }

    }

    class Program
    {
        static void Main()
        {
            List<film> filmler = new List<film> ();
            bool devamET = true;

            while (devamET)
            {
                //film bilgisi
                Console.WriteLine("Film adı giriniz.");
                string isim = Console.ReadLine();

                //puan
                Console.WriteLine("IMDB puanını giriniz");
                double puan = Convert.ToInt32(Console.ReadLine());
                if (puan <0 || puan > 10)
                {
                    Console.WriteLine("geçerli puan giriniz.");
                }
                else
                {
                    Console.WriteLine("puan girildi.");
                }

                //yeni film listesi oluşturma
                film yeniFilm = new film (isim, puan);
                filmler.Add (yeniFilm);

                Console.WriteLine("yeni film eklemek ister misiniz? evet/hayır");
                string cevap = Console.ReadLine().ToLower();

                devamET = cevap == "evet";
            }

            //bütün filmler listelensin
            Console.WriteLine("Tüm filmler:");

            foreach (film film in filmler)
            {
                Console.WriteLine($"isim: {film.Isim}\npuanı: {film.Puan}");
            }

            //IMDB puanı 4 ve 9 arasında olanlar

            Console.WriteLine("IMDB puanı 4 ve 9 arasında olan filmler:");
            foreach ( film film in filmler)
            {
                if (film.Puan >=4 && film.Puan<=9 )
                {
                    Console.WriteLine($"isim: {film.Isim} \npuan: {film.Puan}");
                }
            }

            //ismi a ile başlayanlar

            Console.WriteLine("İsmi A harfi ile başlayan fimler");
            foreach (film film in filmler)
            {
                if (film.Isim.StartsWith("A", StringComparison.OrdinalIgnoreCase)) ;
                {
                    Console.WriteLine($"isim: {film.Isim} \n puan: {film.Puan}");
                }
            }
        }

        


    }
}
    