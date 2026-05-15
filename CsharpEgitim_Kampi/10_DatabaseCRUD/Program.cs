using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRUD --->CREATE-READ-UPDATE-DELETE

            Console.WriteLine("**** Menü Sipariş İşlem Paneli ****");
            Console.WriteLine();

            Console.WriteLine("-----------------------------------");
            Console.WriteLine();

            #region Kategori Ekleme işlemi
            //Console.Write("Eklemek  istediğiniz kategori adi girin: ");
            //Console.Write("Eklemek  istediğiniz kategori adi girin: ");
            //string categoryName = Console.ReadLine();
            //SqlConnection connection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=DbProduct;Trusted_Connection=True;");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory(CategoryName) values(@p1)", connection);
            //command.Parameters.AddWithValue("@p1",categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori başarılı bir şekilde eklendi");
            #endregion

            #region Ürün Ekleme işlemi

            //string productName;
            //int productStock;
            //decimal purchasePrice;
            //decimal salePrice;

            //Console.Write("Ürün Adi: ");
            //productName = Console.ReadLine();

            //Console.Write("Stock sayısı: ");
            //productStock =int.Parse(Console.ReadLine());

            //Console.Write("Ürün Satış  fiyatı: ");
            //purchasePrice =decimal.Parse(Console.ReadLine());

            //Console.Write("Ürün Fiyatı: ");
            //salePrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=DbProduct;Trusted_Connection=True;");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct(ProductName,ProductStock,PurchasePrice,SalePrice) values(@p1,@p2,@p3,@p4)",connection);

            //command.Parameters.AddWithValue("@p1",productName);
            //command.Parameters.AddWithValue("@p2",productStock);
            //command.Parameters.AddWithValue("@p3",purchasePrice);
            //command.Parameters.AddWithValue("@p4",salePrice);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Ekleme işlemi başarılı bir şekilde eklendi");



            #endregion

            #region Ürün Listeleme işlemi

            //SqlConnection connection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=DbProduct;Trusted_Connection=True;");
            //connection.Open();

            //SqlCommand command = new SqlCommand("select * from TblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);

            //foreach(DataRow row in dt.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " "); 
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Ürün silme işlemi 
            //Console.Write("Sileneck Ürün Id girin: ");
            //int productId = int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=DbProduct;Trusted_Connection=True;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("delete TblProduct where ProductID=@p1",connection);
            //command.Parameters.AddWithValue("@p1",productId);
            //connection.Close();
            //Console.Write("Ürün başarılı bir şekilde silindi");
            #endregion

            #region Ürün güncelleme
            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId =int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek Ürün adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncelleneck Ürün stock sayısı: ");
            //int productStock = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün toplamı fiyati: ");
            //decimal purchasePrice = decimal.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün fiyatı: ");
            //decimal price = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=DbProduct;Trusted_Connection=True;");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct set ProductName=@p1, ProductStock=@p2,PurchasePrice=@p3,SalePrice=@p4 where ProductID =@p5", connection);
            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p2", productStock);
            //command.Parameters.AddWithValue("@p3", purchasePrice);
            //command.Parameters.AddWithValue("@p4", price);
            //command.Parameters.AddWithValue("@p5", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
          
           

            #endregion


            Console.WriteLine();

        }
    }
}
