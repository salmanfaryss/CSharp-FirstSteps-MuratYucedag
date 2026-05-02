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
            #region Double değişkenler
            //double number = 25;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double orangePrice, applePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //orangePrice = 10;
            //applePrice = 15;
            //strawberryPrice = 30;
            //potatoPrice = 20;
            //tomatoPrice = 40;

            //Console.WriteLine("---- Portakal Birim fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---- Elma Birim fiyatı: " + applePrice + " TL");
            //Console.WriteLine("---- Çilek Birim fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("---- Potato Birim fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim fiyatı: " + tomatoPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //strawberryGram = 0.75;
            //potatoGram = 1.245;
            //tomatoGram = 0.700;
            //orangeGram = 1.452;


            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;


            //Console.WriteLine("Alınan Ürün:   Elma - " + " Birim Fiyat:  " + applePrice + " - Gramaj:   " + appleGram + " -  Total Tutarı: " + appleTotalPrice);
            //Console.WriteLine();

            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün: Potato - " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün: Portakl - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Sipariş Tutarı: " + shoppingTotalPrice);
            #endregion

            #region Char değişken

            //char harf = 'B';
            //Console.WriteLine(harf);
            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler
            //Console.WriteLine();

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumara;

            //Console.Write("Yolcu Adi: ");
            //passengerName = Console.ReadLine();

            //Console.WriteLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.WriteLine();
            //Console.Write("İlçe bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.WriteLine();
            //Console.Write("Şehir bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.WriteLine();
            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.WriteLine();
            //Console.Write("Yolcu TC: ");
            //passengerIdentityNumara = Console.ReadLine();
            //Console.WriteLine();

            //Console.WriteLine("Yolcu TC kimlik No: " + passengerIdentityNumara + " - Yolcu Adı Soyad: " + passengerName + " - " + passengerSurname  + " - " + passengerDistrict + " / " + passengerCity + " - " + passengerAge);
            #endregion


            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler
            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);
            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            Console.Read();
        }
    }
}
