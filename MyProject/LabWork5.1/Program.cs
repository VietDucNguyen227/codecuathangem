using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace LabWork5._1
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int choice;
            Console.WriteLine("==========Menu==========");
            Console.WriteLine("1.Add Product");
            Console.WriteLine("2.Edit Product");
            Console.WriteLine("3.Delete Product");
            Console.WriteLine("4.View all Product");
            Console.WriteLine("5.Search Product by ID");
            Console.WriteLine("6.Seacrh Product by Name");
            Console.WriteLine("7.End ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    CreateData();
                    break;
                case 2:
                    EditData();
                    break;
                case 3:
                    DeleteData();
                    break;
                case 4:
                    ReadData();
                    break;
                case 5:
                    SearchByID();
                    break;
                case 6:
                    SearchByName(); 
                    break;
                case 7:
                    Console.WriteLine("Thank you for using our services!!!");
                    break;
                default:
                    break;
            }
        }
        static void ReadData()
        {
            ConnectionDatabase connectionDB = new ConnectionDatabase();
            SqlConnection connection = connectionDB.GetConnection();

            string query = "SELECT * FROM product";
            SqlCommand sqlCommand = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            /*while (sqlDataReader.Read())
            {
                Console.WriteLine("Product name: " + sqlDataReader[1] + "||| Product Description: " + sqlDataReader[2] + " |||Product Price: " + sqlDataReader[3]);
            }*/

            ArrayList list = new ArrayList();
            list.Add(sqlDataReader);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            connection.Close();
        }

        static void CreateData()
        {
            ConnectionDatabase connectionDB = new ConnectionDatabase();
            SqlConnection connection = connectionDB.GetConnection();

            string query = "INSERT INTO product VALUES(@proName,@proDesc,@price)";

            SqlCommand sqlCommand = new SqlCommand(query, connection);
            Console.WriteLine("Please Enter Product's Name: ");
            sqlCommand.Parameters.AddWithValue("@proName", Console.ReadLine());
            Console.WriteLine("Please Enter Product's Description: ");
            sqlCommand.Parameters.AddWithValue("@proDesc", Console.ReadLine());
            Console.WriteLine("Please Enter Product's Price: ");
            sqlCommand.Parameters.AddWithValue("@price", double.Parse(Console.ReadLine()));

            connection.Open();
            
            int row = sqlCommand.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Insert thanh cong");
        }

        public static void EditData()
        {
            int choice;
            Console.WriteLine("Where do you want to edit? ");
            Console.WriteLine("1. Product's Name");
            Console.WriteLine("2. Product's Description");
            Console.WriteLine("3. Product's Price");
            Console.WriteLine("4. Quit");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    EditName();
                    break;
                case 2:
                    EditDesc();
                    break;
                case 3:
                    EditPrice();
                    break;
                case 4:
                    ReadData();
                    break;
            }

        }
        public static void EditName()
        {
            ConnectionDatabase connectionDB = new ConnectionDatabase();
            SqlConnection connection = connectionDB.GetConnection();

         
                    string query = "UPDATE product SET proName = @Name  WHERE id = @id";
            SqlCommand sqlCommand = new SqlCommand(query, connection);

            Console.WriteLine("Enter your Product's ID to change it's name: ");
            sqlCommand.Parameters.AddWithValue("@id", double.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter your new Product's name: ");
            sqlCommand.Parameters.AddWithValue("@Name", Console.ReadLine());
            
            connection.Open();

            int row = sqlCommand.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Update thanh cong");
        }
        public static void EditDesc()
        {
            ConnectionDatabase connectionDB = new ConnectionDatabase();
            SqlConnection connection = connectionDB.GetConnection();


            string query = "UPDATE product SET proDesc = @Desc  WHERE id = @id";
            SqlCommand sqlCommand = new SqlCommand(query, connection);

            Console.WriteLine("Enter your Product's ID to change it's description: ");
            sqlCommand.Parameters.AddWithValue("@id", double.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter your new Product's description: ");
            sqlCommand.Parameters.AddWithValue("@Desc", Console.ReadLine());

            connection.Open();

            int row = sqlCommand.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Update thanh cong");
        }
        public static void EditPrice()
        {
            ConnectionDatabase connectionDB = new ConnectionDatabase();
            SqlConnection connection = connectionDB.GetConnection();


            string query = "UPDATE product SET price = @price  WHERE proName = @Name";
            SqlCommand sqlCommand = new SqlCommand(query, connection);

            Console.WriteLine("Enter your Product's name to change it's price: ");
            sqlCommand.Parameters.AddWithValue("@Name", Console.ReadLine());
            Console.WriteLine("Please enter your new Product's price");
            sqlCommand.Parameters.AddWithValue("@price", double.Parse(Console.ReadLine()));

            connection.Open();

            int row = sqlCommand.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Update thanh cong");
        }

        public static void DeleteData()
        {
            ConnectionDatabase connectionDB = new ConnectionDatabase();
            SqlConnection connection = connectionDB.GetConnection();

            string query = "DELETE product WHERE proName = @Name";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            Console.WriteLine("Enter the product's name to delete it: ");
            sqlCommand.Parameters.AddWithValue("@Name", Console.ReadLine());

            connection.Open();

            int row = sqlCommand.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Delete thanh cong");
        }
        
        public static void SearchByID()
        {
            ConnectionDatabase connectionDB = new ConnectionDatabase();
            SqlConnection connection = connectionDB.GetConnection();

            string query = "SELECT * FROM product WHERE id = @id";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            Console.WriteLine("Enter your Product's ID you want to search: ");
            sqlCommand.Parameters.AddWithValue("@id", double.Parse(Console.ReadLine()));

            connection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Console.WriteLine("Product name: " + sqlDataReader[1] + "||| Product Description: " + sqlDataReader[2] + " |||Product Price: " + sqlDataReader[3]);
            }

            connection.Close();
        }

        public static void SearchByName()
        {
            ConnectionDatabase connectionDB = new ConnectionDatabase();
            SqlConnection connection = connectionDB.GetConnection();

            string query = "SELECT * FROM product WHERE proName = @Name";
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            Console.WriteLine("Enter your Product's name you want to search: ");
            sqlCommand.Parameters.AddWithValue("@Name", (Console.ReadLine()));

            connection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Console.WriteLine("Product name: " + sqlDataReader[1] + "||| Product Description: " + sqlDataReader[2] + " |||Product Price: " + sqlDataReader[3]);
            }

            connection.Close();
        }

    }
}
