using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 10; //sayı1 in değeri = 10
            int sayi2 = 30;//sayı2 nin değeri 30
            sayi1 = sayi2;//sayı1 in değeri = sayi2 nin değeri. yani sadece değeri aktarırsın sayı1 ile olan bütün irtibarın kopar
            sayi2 = 65;//amaç sadece değeri atamak.
            //sayi1 = ?? 30 olurdu.


            int[] sayilar1 = new int[] { 10, 20, 30 };//sayılar 1
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar[0] = ?? 999 olurdu. 


            //Değer tip = Sayısal veri tipleri(sayısal görüntü tipleri) ( int,decimal,float,double,bool(arka planda 0 ve 1 i tutar)
            //Referans tip = array, class, interface, 
            // Bellekte stack ve heap diye 2 alan vardır. new bellekten bir adress oluştur. heap de yeni bir yer olurşut demek
            //değer tip olanlar stack de gerçekleşir (olaylar da stackte tanımlanır.)amaç sadece değeri kopyalayıp irtibatı koparır
            // 1.sayılar 1 diye stack de değişken tanımladım. new dediğimiz anda heapte yeni biralan oluştur ve sayıları oraya yaz demek.
            //2.heap bir adress değeri tutar. sayılar 1 heaptaki adresste tutulut. sayılar 2 diye bir şey tanımlanır ve heapte sayılar2 için bir adress oluşturulur.
            //3. in array (referans tip) sayılar1 in referans numarası dayılar2 nin referans numarasına eşittir diye okunur. yani sayılar 1 in adressi sayılar 2 nin adressine dahil olur kendi adressi ile işi klamadı. yani sayılar1 adress kopyalaması yapar.
            //değer tiplerde değeri atıyorosun, referans tipte adresse atıyorsun.
            //4. sayılar 2 nin referans numarasının 0.elemanı 999 olursa, sayılar 1 i sayılar 2 yi tuttuğu için sayılar 1 in de 0.değeri 999 olur.
            //sayılar 1 in eski adressini tutan kimse olmadığı için, çöp toplayıcısı sayı bellekten atar. çünkü tutan bir referans yok anlamı da kalmaz. bu yüzden bellekten atar. 
        }
    }
}
