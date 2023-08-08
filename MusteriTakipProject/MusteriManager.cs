using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MusteriTakipProject
{
    class MusteriManager
    {
        public ArrayList musteriList = new ArrayList();

        public void MusteriEkle()
        {
            Musteri musteri = new Musteri();
            Console.WriteLine("Name: ");
            musteri.MusteriName = Console.ReadLine();
            Console.WriteLine("Surname: ");
            musteri.MusteriSurname = Console.ReadLine();
            Console.WriteLine("TCNO: ");
            musteri.MusteriTCNo = Console.ReadLine();
            Console.WriteLine("Adress: ");
            musteri.MusteriAdress = Console.ReadLine();
            Console.WriteLine("TelNo: ");
            musteri.MusteriTelNo = Console.ReadLine();
            musteri.MusteriId = musteriList.Count + 1;
            musteriList.Add(musteri);
        }//Ekle
        public void MusteriSil()
        {
            int secilenMusteriId = int.Parse(Console.ReadLine());
            Musteri musteriToRemove = null;
            foreach (Musteri m in musteriList)
            {
                if (secilenMusteriId.Equals(m.MusteriId))
                {
                    musteriToRemove = m;
                    break;
                }
            }
            if (musteriToRemove != null)
            {
                musteriList.Remove(musteriToRemove);
                Console.WriteLine("Müşteri Başarıyla Silindi");
            }
            else
            {
                Console.WriteLine("Belirtilen Id'ye ait müsteri yok");
            }
        }//Sil
        public void MusteriBilgiGüncelleme()
        {
            int secilenMusteriId2 = int.Parse(Console.ReadLine());
            bool bulunanMusteri = false;
            foreach (Musteri m in musteriList)
            {
                if (secilenMusteriId2.Equals(m.MusteriId))
                {
                    Console.WriteLine("Telefon numarası güncellemek => 1 " + "Adresi güncellemek => 2 " + " Çıkış => 0");
                    int güncellemeSecilen = int.Parse(Console.ReadLine());
                    bulunanMusteri = true;
                    if (güncellemeSecilen == 0)
                    {
                        break;
                    }
                    else if (güncellemeSecilen == 1)
                    {
                        Console.WriteLine("Yeni telefon numaranızı giriniz: ");
                        m.MusteriTelNo = Console.ReadLine();
                    }
                    else if (güncellemeSecilen == 2)
                    {
                        Console.WriteLine("Yeni Adresinizi giriniz: ");
                        m.MusteriAdress = Console.ReadLine();
                    }
                }
                else if (bulunanMusteri == false)
                {
                    Console.WriteLine("Bu Id'ye sahip müşteri bulunumadı");
                }
            }
        }//Güncelleme
        public void MusteriList()
        {
            foreach (Musteri m in musteriList)
            {
                Console.WriteLine(m.MusteriName + " " + m.MusteriSurname + " " + m.MusteriTCNo + " " + m.MusteriAdress + " " + m.MusteriTelNo + " " + m.MusteriId);
            }
        }//Listele
    }
}






//public void MusteriSil()
//{

//}

//public void MusteriGüncelleme()
//{

//}
//public void MusteriListele()
//{

//}
