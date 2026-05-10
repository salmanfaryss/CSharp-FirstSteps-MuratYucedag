using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi örnekleri

            //1.2.3.4.5
            //Ankara-Adana-Istanbul-Izmir
            //DeğişkenTürü[] diziAdi = new DeğişkenTürü[eleman sayısı]

            //string[] cities = new string[5];
            //cities[0] = "Bamako";
            //cities[1] = "Dakar";
            //cities[2] = "Abidjan";
            //cities[3] = "Bobo";
            //cities[4] = "Ouaga";
            //Console.Write(cities[1]);


            #endregion

            #region Dizideki Tüm elemenler Listeleme

            //string[] color = { "Sarı", "Kirmizi", "Mavi", "Yeşil", "Beyaz", "Turunc" };
            //for(int i =0; i<color.Length; i++)
            //{
            //    Console.WriteLine(color[i]);
            //}

            //int[] number = { 4, 84, 20, 100, 25, 47, 488, 235, 69, 74 };
            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i] % 3 == 0)
            //    {
            //        Console.WriteLine(number[i]);
            //    }
            //}


            //char[] symbole = { 'a', 'b', 'c', '*', '+', '/' };
            //for(int i = 0; i < symbole.Length; i++)
            //{
            //    Console.WriteLine(symbole[i]);
            //}

            //int[] myArrays = { 4, 84, 20, 100, 25, 47, 488, 235, 69, 74 };

            //int maxNumber = myArrays[0];
            //for (int i = 0; i < myArrays.Length; i++)
            //{
            //    if (myArrays[i] > maxNumber)
            //    {
            //        maxNumber = myArrays[i];
            //    }

            //}
            //Console.WriteLine(maxNumber);

            //int[] myArrays = { 4, 84, 20, 100, 25, 47, 488, 235, 69, 74 };
            //Array.Sort(myArrays);

            //for(int i = 0; i < myArrays.Length; i++)
            //{
            //    Console.WriteLine(myArrays[i]);
            //}

            #endregion

            #region Dizi Metotlar

            //string[] customer = { "Ali", "Buse", "Zeynap", "AyşeGül", "Çinar" };
            //int index = Array.IndexOf(customer, "Buse");
            //Console.WriteLine(index);
            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. ŞehriGiriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");
            //for(int i = 0;i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //int[] number = {1,2, 3, 4,5,6,7,8,9,0};
            //Console.WriteLine("Çift sayılar");
            //for(int i = 0; i < number.Length; i++)
            //{
            //    if (number[i] % 2 == 0)
            //    {
            //        Console.WriteLine(number[i]);
            //    }
            //}
            //Console.WriteLine("---------");
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();
            //for(int i = 0; i < number.Length; i++)
            //{
            //    if(number[i] % 2 ==1)
            //    {
            //        Console.WriteLine(number[i]);
            //    }
            //}
            #endregion
            Console.Read();
        }
    }
}
