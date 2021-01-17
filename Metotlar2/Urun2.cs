using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar2
{
    class Urun2
    {
        //property = özellik

        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }


    }
}
//Class isimlendirmeleri pascal case dediğimiz kelimelerin ilk harfleri büyük yazılır.
//oublic = erişim bildirgecidir.
//classta birden fazla elemanı tutabiliriz(int,string vs)
//Urun2 de bir tip aslında ama briden fazla şeyi Urun2 diyerek içinde tutabiliyoruz.
