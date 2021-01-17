using System;

namespace Metotlar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun2 urun1 = new Urun2(); //Classı çağırma şeklimiz
            urun1.Adi = "Elma"; //urun1 in adı
            urun1.Fiyati = 15; //urun1 in fiyatı
            urun1.Aciklama = "Amasya elması";//urun1 in açıklaması.

            Urun2 urun2 = new Urun2(); //Urun2'nin içinde yani Urun2de olan bir başka urunumu tanıtıyorum
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            //diziler çoğul isimlendirirlir.
            Urun2[] urunler = new Urun2[] {urun1, urun2 }; //array= bir veri tipinde datayı tutan yapı. yani istediklerini 1 yerde tutabilirsin.

            foreach (Urun2  urun in urunler)
                       
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------------");

                //var'ı Uurn2 diye yapmasak da olurdu yalnızca var da diyip bırakabilirdik. in urunler dediğimizde urunler dizindekileri tek tek gez. urunlere gelen verileri tek tek ekrana basıyor.
                //urun demesek de olurdu ax, gibi farklı şeyler de diyebilirdik.elemenalrı tek tek gezip dönüyorken o anki elemana takma isim vermiş oluyoruz(elma urun gibi).Urun2 veri tipidir. c# tip güvenli olduğu için, neyle çalışacağını bilmek istediği için yazdıkç var da yazıp bırakabilirdik.
                //Classlar özellik tutuyor.(örn. müşteri adı, müşteri soyadı vs.)

            }
            Console.WriteLine("-----------METOTLAR-------------");
            //instance = örnek
            //enscapsulation, ayrı ayrı yazacağımız ve düzensiz olacak bir yapıyı düzene sokamktır. Bunlara da class denir.

            SepetManager2 sepetManager = new SepetManager2(); // classı çağırma şeklimiz
            sepetManager.Ekle(urun1); // sepetmanager.ekle dediğimizde onun içindekiler hemen eklenir buraya/siteye.
            sepetManager.Ekle(urun2);//urun2yi istediğim zaman sepete ekleyebileceğim.
            //SepetManager de ürünün adını yazırmak için console write da yardırdık. program.cs de ise hangi ürünün(urun1 mi urun 2 mi) adını eklemek istediğimizi belirttik.


            sepetManager.Ekle2("armut", "yeşil armut", 12);
            sepetManager.Ekle2("elma", "yeşil elma", 12);
            sepetManager.Ekle2("armut", "diyarbakır karpuzu", 12);








        }
    }
}

//metotlar, tekrar tekrar kullanılabilirliği sağlayan bir ortam sağlar
//DO NOT REPEAT YOURSELF-DRY-CLEAN CODE-Best practice(doğru uygulama teknikleri)
