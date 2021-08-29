using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            TuzelMusteri musteri2 = new TuzelMusteri();
            Musteri musteri3= new GercekMusteri(); //Baseclass subclassların adresini tutabilir
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);  //hepsi çağıralabilir.
        }
    }
}
