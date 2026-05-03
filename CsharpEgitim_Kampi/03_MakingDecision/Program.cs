using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            //Console.Write("Lütfen Şifreniz Girin: ");
            //string password = Console.ReadLine();
            //if(password == "1234")
            //{
            //    Console.WriteLine("Hoş Geldiniz");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Bilgi");
            //}

            //string capital, country;
            //Console.Write("Başkentı girin: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülek Girin:");
            //country = Console.ReadLine();

            //if(capital =="Ankara" &  country == "Turkiye")
            //{
            //    Console.Write("Doğru bilgi");
            //}
            //else
            //{
            //    Console.Write("Yanlış Bilgi");
            //}

            //int exam1, exam2, exam3, average;

            //Console.Write("1.Sınav Notu girin: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Console.Write("2.Sınav Notu girin: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Console.Write("3.Sınav Notu girin: ");
            //exam3 = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Not Ortalaması: " + average);

            //if(average > 0 && average <= 50)
            //{
            //    Console.WriteLine("Sonuç Vasat");
            //}
            //else if( average > 50 && average <= 70)
            //{
            //    Console.WriteLine("Sonuç Orta");
            //}
            //else if(average > 70 && average <= 84)
            //{
            //    Console.WriteLine("Sonuç Iyi");
            //}
            //else if(average > 84 && average <=100)
            //{
            //    Console.WriteLine("Sonuç çok iyi");
            //}

            //string city;

            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "Adana" || city == "Ankara" || city == "Izmir" || city == "Bursa")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("girdiğiniz şehir bilgisi yok");
            //}
            //string username;
            //Console.Write("Lütfen kullanıcı adınız girin: ");
            //username = Console.ReadLine();
            //if( username != "admin")
            //{
            //    Console.WriteLine("kullanıcı adı hatalı");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz! ");
            //}


            #endregion

            #region Mod işlemi

            //int number = 26;
            //int result = number % 5;

            //Console.Write(result);
            //Console.Write("Lütfen 1.sayı girin: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.sayı girin: ");
            //int num2 = int.Parse(Console.ReadLine());
            //int result = num1 % num2;

            //Console.WriteLine($"1.sayı ve 2.sayı kalan:{result}");


            #endregion

            #region Char Değişkenler ile Karar Yapıları

            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //char harf =char.Parse( Console.ReadLine());


            //if(harf == 'F'  || harf == 'f')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //else if(harf == 'G' || harf == 'g')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else if(harf == 'B' || harf == 'b')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            #endregion


            #region  Örnek Proje Uygulaması

            //    Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------------------");
            //    Console.WriteLine("1-Ana Yemekler");
            //    Console.WriteLine("2-Çorbalar");
            //    Console.WriteLine("3-Pizzalar");
            //    Console.WriteLine("4-İçecekler");
            //    Console.WriteLine("5-Tatlılar");
            //    Console.WriteLine("-----------------------------");
            //    Console.WriteLine();
            //    string menuItem;

            //    Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //    menuItem = Console.ReadLine();




            //if (menuItem == "1")
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("------------Ana Yemekler------------");
            //        Console.WriteLine();
            //        Console.WriteLine("1-Köri Soslu Tavuk");
            //        Console.WriteLine("2-Kızartma Tabağı");
            //        Console.WriteLine("3-Fasulye Pilav");
            //        Console.WriteLine("4-Fırında Somon");
            //        Console.WriteLine("5-Patlıcan Musakka");
            //        Console.WriteLine();
            //        Console.WriteLine("------------Ana Yemekler------------");
            //        Console.WriteLine();

            //    }
            //    if (menuItem == "2")
            //    {

            //        Console.WriteLine();
            //        Console.WriteLine("------------Çorbalar------------");
            //        Console.WriteLine();
            //        Console.WriteLine("1-Mercimek Çorbası");
            //        Console.WriteLine("2-Ezogelin Çorba");
            //        Console.WriteLine();
            //        Console.WriteLine("------------Çorbalar------------");

            //        Console.WriteLine();
            //    }
            //    if (menuItem == "3")
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("------------Pizzalar------------");
            //        Console.WriteLine();
            //        Console.WriteLine("1-Akdeniz Pizza");
            //        Console.WriteLine("2-Margaritha");
            //        Console.WriteLine("3-Tavuklu Pizza");
            //        Console.WriteLine();
            //        Console.WriteLine("------------Pizzalar------------");

            //        Console.WriteLine();
            //    }
            //    if (menuItem == "4")
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("------------İçecekler------------");
            //        Console.WriteLine();
            //        Console.WriteLine("1-Kola");
            //        Console.WriteLine("2-Ayran");
            //        Console.WriteLine("3-Su");
            //        Console.WriteLine();
            //        Console.WriteLine("------------İçecekler------------");
            //        Console.WriteLine();
            //    }
            //    if (menuItem == "5")
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("------------Tatlılar------------");
            //        Console.WriteLine();
            //        Console.WriteLine("1-Triliçe");
            //        Console.WriteLine("2-Kazandibi");
            //        Console.WriteLine("3-Sütlaç");
            //        Console.WriteLine();
            //        Console.WriteLine("------------Tatlılar------------");
            //        Console.WriteLine();
            //    }


            #endregion

            #region Swich Case

            //Console.Write("Lütfen Ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.Write("Ocak");
            //        break;
            //    case 2:
            //        Console.Write("Şubat");
            //        break;
            //    case 3:
            //        Console.Write("Mart");
            //        break;
            //    case 4:
            //        Console.Write("Nisan");
            //        break;
            //    case 5:
            //        Console.Write("Mayıs");
            //        break;
            //    case 6:
            //        Console.Write("Hazıran");
            //        break;
            //    case 7:
            //        Console.Write("Temmuz");
            //        break;
            //    case 8:
            //        Console.Write("Ağostos");
            //        break;
            //    case 9:
            //        Console.Write("Eylül");
            //        break;
            //    case 10:
            //        Console.Write("Ekim");
            //        break;
            //    case 11:
            //        Console.Write("Kasim");
            //        break;
            //    case 12:
            //        Console.Write("Aralık");
            //        break;
            //    default:
            //        Console.Write("Hatalı veri giriş");
            //        break;

            //}

            #endregion

            #region Swich Case Hesap Makinesi
            //char symbole;
            //int number1, number2,result;

            //Console.Write("1.Sayı Girin: ");
            //number1 =int.Parse(Console.ReadLine());

            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbole = char.Parse(Console.ReadLine());

            //Console.Write("2.Sayı Girin: ");
            //number2 =int.Parse(Console.ReadLine());


            //switch (symbole)
            //{
            //    case '+': 
            //        result = number1 + number2;
            //        Console.Write("Girdiğiniz sayılar toplamı: " +  result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.Write("Girdiğiniz sayılar eksi: " + result);
            //        break;
            //    case '*':
            //        result = number1 + number2;
            //        Console.Write("Girdiğiniz sayılar Çarpı: " + result);
            //        break;
            //    case '/':
            //        result = number1 + number2;
            //        Console.Write("Girdiğiniz sayılar bölme: " + result);
            //        break;
                

            //}

            #endregion
            Console.Read();
        }
    }
}
