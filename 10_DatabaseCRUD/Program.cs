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
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-----------------------------------------");

            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek istediğiniz kategori adı : ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-J9F7GS9\\MSSQLSERVER02;initial Catalog=EgitimKampiDB;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into Tbl_Category(CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Kategori başarıyla eklendi");

            #endregion

            #region Ürün Ekleme İşlemi
            //string productName;
            //decimal productPrice;
            //bool productStatus;
            //Console.Write("Ürün adı : ");
            //productName = Console.ReadLine();
            //Console.Write("Ürünün fiyatı : ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-J9F7GS9\\MSSQLSERVER02; initial Catalog=EgitimKampiDB;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into Tbl_Product(ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürün eklemesi başarılı");


            #endregion

            #region Ürün Listeleme İşlemi
            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-J9F7GS9\\MSSQLSERVER02; initial Catalog=EgitimKampiDB;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * from Tbl_Product", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.WriteLine(item.ToString());
            //    }
            //    Console.WriteLine();
            //}
            //connection.Close();


            #endregion

            #region Ürün Silme İşlemi
            //Console.Write("Silinecek ürünün id'sini girin : ");
            //int productId = int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-J9F7GS9\\MSSQLSERVER02; initial Catalog=EgitimKampiDB;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete from Tbl_Product where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("İlgili kayıt silinmiştir.");

            #endregion

            #region Ürün Güncelleme İşlemi
            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-J9F7GS9\\MSSQLSERVER02; initial Catalog=EgitimKampiDB;integrated security=true");
            //connection.Open();
            //Console.Write("Güncellenecek ürün için Id giriniz : ");
            //int productId = int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek ürün adı : ");
            //string productName = Console.ReadLine();
            //Console.Write("Güncellenecek ürün fiyatı : ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());
            //SqlCommand command = new SqlCommand("Update Tbl_Product Set ProductName=@productName,ProductPrice=@productPrice where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@ProductName", productName);
            //command.Parameters.AddWithValue("@ProductPrice", productPrice);
            //command.Parameters.AddWithValue("@ProductId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Güncelleme başarılı");

            #endregion


            Console.ReadLine();



        }
    }
}
