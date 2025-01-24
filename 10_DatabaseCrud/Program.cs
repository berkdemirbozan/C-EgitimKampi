using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud-->Create-Read-Update-Delete


            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-------------------------------");
            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-90M90HO\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");


            //connection.Open();  // bağlantı aç.
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection); //ekleme işlemi.
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery(); //koşulsuz bir şekilde sorguyu çalıştır demek.
            //connection.Close(); // bağlantı kapat.

            //Console.Write("Başarılı bir şekilde eklendi..");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice=decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-90M90HO\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct(ProductName,ProductPrice,ProductStatus) values(@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Ürün eklemesi başarılı..");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-90M90HO\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command); //sql'den verileri çekmek için bir köprü görevi görür.
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable); // içini doldurmak için yazıyoruz.

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-90M90HO\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme işlemi yapıldı..");

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün ID: ");
            //int productId= int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName= Console.ReadLine();
            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice= decimal.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-90M90HO\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct set ProductName=@ProductName,ProductPrice=@productPrice where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@ProductName",productName);
            //command.Parameters.AddWithValue("@ProductPrice",productPrice);
            //command.Parameters.AddWithValue("@ProductId",productId);
            //command.ExecuteNonQuery();


            //connection.Close();

            //Console.WriteLine("Güncelleme Başarılı..");

            #endregion

            Console.Read();
        }
    }
}
