using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***** C# Veritabali Ürün - Kategori Bilgisi *****");
            Console.WriteLine();
            Console.WriteLine();
            string tableNumber;
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1- Kategoriler");
            Console.WriteLine("2- Ürünler");
            Console.WriteLine("3- siparişler");
            Console.WriteLine("4- Çikiş Yap");
            Console.WriteLine();
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını girin: ");
             tableNumber = Console.ReadLine();


            SqlConnection connection =new SqlConnection("Server=localhost\\SQLEXPRESS;Database=DbProduct;Trusted_Connection=True;");
            connection.Open();

            SqlCommand command = new SqlCommand("select * from TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
           
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach(DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
               
            }
            
            Console.Read();
        }
    }
}
