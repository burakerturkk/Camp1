using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Variables

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.87;
            //orangePrice = 20.23;
            //strawberryPrice = 45;
            //potatoPrice = 12.31;
            //tomatoPrice = 8.76;
            //Console.WriteLine("---- Elma Birim Fiyatı : " + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı : " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı : " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı : " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı : " + tomatoPrice + " TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.254;
            //orangeGram = 2.341;
            //strawberryGram = 0.750;
            //potatoGram = 3.1;
            //tomatoGram = 2.7;

            //double appleTotalPrice, orangeTotalPrice, strawberryTotalPrice, potatoTotalPrice,tomatoTotalPrice;
            //appleTotalPrice = applePrice * appleGram;
            //orangeTotalPrice = orangePrice * orangeGram;
            //strawberryTotalPrice = strawberryPrice * strawberryGram;
            //potatoTotalPrice=potatoPrice * potatoGram;
            //tomatoTotalPrice = tomatoPrice * tomatoGram;
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün : Elma - " + " Birim Fiyat : " + applePrice + " - Gramaj : " + appleGram + " - Toplam : " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün : Portakal - " + " Birim Fiyat : " + orangePrice + " - Gramaj : " + orangeGram + " - Toplam : " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün : Çilek - " + " Birim Fiyat : " + strawberryPrice + " - Gramaj : " + strawberryGram + " - Toplam : " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün : Patates - " + " Birim Fiyat : " + potatoPrice + " - Gramaj : " + potatoGram + " - Toplam : " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün : Domates - " + " Birim Fiyat : " + tomatoPrice + " - Gramaj : " + tomatoGram + " - Toplam : " + tomatoTotalPrice);
            //double totalPrice = appleTotalPrice + orangeTotalPrice+ strawberryTotalPrice+potatoTotalPrice+ tomatoTotalPrice;
            //Console.WriteLine("Toplam Fiyat : " + totalPrice);

            #endregion

            #region Input String Type From Keyboard
            //Console.WriteLine("***** C# Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            //Console.Write("Yolcu Adı : ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyad : ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Yolcu İl : ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu İlçe : ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Yolcu Yaş : ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu TC kimlik no : ");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------------------");
            //Console.WriteLine("Yolcu : " + passengerName + " " + passengerSurname);
            //Console.WriteLine("Yolcu Yaş : " + passengerAge);
            //Console.WriteLine("Yolcu TC : " + passengerIdentityNumber);
            //Console.WriteLine("Yolcu İkametgah : " + passengerCity + "/" + passengerDistrict);


            #endregion

            #region Integer Type From Keyboard
            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 3000;
            //tvPrice = 7000;
            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz : ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz : ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz : ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz : ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = (shoesCount * shoesPrice) + (computerCount*computerPrice) + (chairCount*chairPrice) + (tvCount*tvPrice);

            //Console.WriteLine("Ödenecek toplam tutar : " + totalPrice + " TL");

            #endregion

            #region Double Type From Keyboard
            //double exam1, exam2, exam3, aravage;
            //Console.Write("Lütfen birinci sınav notunu giriniz : ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen ikinci sınav notunu giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen üçüncü sınav notunu giriniz : ");
            //exam3 = double.Parse(Console.ReadLine());
            //aravage = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Sınav ortalamanız : " + aravage);
            #endregion

            Console.Read();
        }
    }
}
