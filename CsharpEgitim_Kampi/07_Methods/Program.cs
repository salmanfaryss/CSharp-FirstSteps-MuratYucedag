using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region void Metotlar
            //()
            //Geriye Değer Döndürmeyen metotlar
            //Customer ---> Listele,ekle,Sil,Güncelle

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Mehmet Çinar");
            //    Console.WriteLine("Ayşe Yıldırım");
            //    Console.WriteLine("Fatih Kaya");
            //}
            //CustomerList();
            #endregion

            #region Geriye Değer döndürmeyen string parametreli Metotlar
            //void WriteMethod(string name)
            //{
            //    Console.WriteLine(name);
            //}
            //WriteMethod("Mehmet");

            //void CustomerCard(string name,string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}
            //CustomerCard("Ahmet", "Yıldız");

            #endregion

            #region Geriye Değer döndürmeyen int parametreli Metotlar

            //void sum(int number1,int number2,int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //sum(5, 5, 5);
            #endregion


            #region Geriye Değer Döndüren Metotlar
            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();


            #endregion


            #region Geriye Değer Döndüren string parametreli Metotlar
            //string CountryCard(string countryName,string CountryCity,string florColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + "- Başkent: " + CountryCity + " Bayrak Rengi: " + florColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke Adınız girin: ");
            //x = Console.ReadLine();

            //Console.Write("Başkentı girin: ");
            //y = Console.ReadLine();

            //Console.Write("Byarak Girin: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            #endregion
            Console.Read();
        }
    }
}
