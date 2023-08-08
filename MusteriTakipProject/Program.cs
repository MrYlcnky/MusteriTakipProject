using MusteriTakipProject;
using System.Collections;


namespace MusteriTakipProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            MusteriManager _musteriManager = new MusteriManager();


            Console.WriteLine("Aşağıdan yapacağınız işlemi seçiniz:");
           

            bool x = true;

            while (x)
            {
                Console.WriteLine("Müşteri Ekle => 1 \n" + "Müşteri Bilgisi Sil => 2\n" + "Müşteri Bilgisi Güncelle => 3 \n" + "Müşteri Listesi Görüntüle => 4\n" + "Çıkış => 0\n");
                int secilenIslem = int.Parse(Console.ReadLine());
               
                if (secilenIslem == 1)
                {
                    //ekle
                    _musteriManager.MusteriEkle();
                }
                else if (secilenIslem == 2)
                {
                    // sil
                    Console.WriteLine("Silmek İstediğiniz müşteri Id'sini giriniz: ");
                    _musteriManager.MusteriSil();
                }
                else if (secilenIslem == 3)
                {
                    //güncelleme
                    Console.WriteLine("Güncellemek istediğiniz müşredi Id'sini giriniz: ");
                    _musteriManager.MusteriBilgiGüncelleme();

                }
                else if (secilenIslem == 4)
                {
                    // liste göster
                    _musteriManager.MusteriList();
                }
                else if (secilenIslem == 0)
                {
                    //çıkış
                    x = false;
                }
                else
                {
                    Console.WriteLine(" Geçerli Bir işlem Numarası Giriniz!!! ");
                }
            }


        }
    }
}







/* Console.WriteLine("Bütün müşteriler : " + musteriList);

           Console.WriteLine("İstenilen Müşteri Id'si: ");
           int istenilen=int.Parse(  Console.ReadLine());

           var istenilenMusteri = musteriList.Find(x => x.MusteriId == istenilen);
           if( istenilenMusteri != null )
           { 

           }
           else
           {
               Console.WriteLine(istenilenMusteri);
           }
           */