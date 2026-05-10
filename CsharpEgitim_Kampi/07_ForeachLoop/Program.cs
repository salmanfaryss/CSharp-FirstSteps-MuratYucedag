using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //Foreach(1;2;3;4)


            //1:Değişken türü
            //2:Değişken adı
            //3:In
            //4:list, koleksiyon, Dizi

            //string[] cities = { "Ankara", "Istanbul", "Bursa", "Izmir", "Antalya" };
            //foreach(string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45, 78, 958, 635, 74, 22, 11, 3, 41, 6578 };
            //foreach(int i in numbers)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region Sinav sistemi Uygulaması
            Console.Write("***  C# Eğitim Kampı Sınav Uygulaması ****");
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki Öğrenci sayısına kullanıcıdan alma

            Console.WriteLine("-----------------------------------------");
            Console.Write("Sınıfınzda kaç Öğrenci var: ");
            //Console.WriteLine();
            int studenCount =int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();

            //Öğrenci isimlerini ve not ortalamalarını 
            string[] studentNames = new string[studenCount];
            double[] studentExamAverage = new double[studenCount];

            for(int i = 0; i < studenCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;


                //Her öğrencinin için 3 sinav notu giriş

                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin  {j + 1}. sinav notunu giriniz:");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }
                Console.WriteLine();
                studentExamAverage[i] = totalExamResult / 3;
                
            }

            for(int i = 0; i < studenCount; i++)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine($"{studentNames[i]} adli öğrencinin ortalaması {studentExamAverage[i]}");

                //Öğrencinin ortalaması ve geçip kalma durumları

                if(studentExamAverage[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adli öğrenci  dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adli öğrenci  dersi kaldı");
                }
                Console.WriteLine("-------------------------------------------------");
            }



            #endregion
            Console.Read();
        }
    }
}
