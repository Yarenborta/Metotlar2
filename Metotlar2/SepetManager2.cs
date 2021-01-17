using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar2
{
    class SepetManager2
    {
        // iismlendirme kuralı maning convention. Ekle nin E si büyük.
        //() var ise orada metod çalışıyor demek.
        //syntax
        //pythondaki deff komutudur.
        public void Ekle(Urun2 urun) //Urun tipidir, urun2 ise aşağıdaki console writeline da vereceğimiz isimlendirme.
        
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adi);//bu parametre bir urun(isimlendirme alliens) alıyor ve bu urunun adını bize ekle kısmında yazdırıyor.
       //ne ekelemek istediğimi metotta belirtmem gerekiyor ki neyi sepete eklediğimize ulaşabilelim.
       // 
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            //ayrıyetten de classa eklenmesi için de Urun classına da "public" eklemesi yapılmalı ki o nesneyi tanısın.
            //eğer bu şekilde yazarsak parantez içindekilerin hepsi birden eklenir 
            //ama bu daha çok zorlar ve hatalı bir yazım türüdür çünkü yeni bir ürün ekeleme ya da çıkarma yaptığımızda her yerden ekleyip sileceğiz.
            Console.WriteLine("tebrikler. sepete eklendi! : " + urunAdi);
        }
    }
}

//Manager,data acces, dal, bll isimlendirmeler standarttır. 
//manager,servis, dal, controller, data acces gibi ifadeler görülürse eğer, bunlar bir operasyon tutuyor demek.
//sepete ekleme, müşteri ile ilgili işlmeler, ürünle alkalı işlemleri managerden yaparız.