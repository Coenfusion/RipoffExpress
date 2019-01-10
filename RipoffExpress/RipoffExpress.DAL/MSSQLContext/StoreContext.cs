using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RipoffExpress.Models;

namespace RipoffExpress.DAL
{
    public class StoreContext : IStoreContext
    {
        private readonly string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RipOffExpress;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public StoreViewModel StoreDetails(int? userId)
        {
            StoreViewModel svm = new StoreViewModel();
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "St_Details",
                CommandType = System.Data.CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("@userId", userId);
            sqlConnection.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    StoreViewModel tempSvm = new StoreViewModel(
                            (int)reader[0],
                            StoreAccount((int)reader[0]),
                            (string)reader[2],
                            (string)reader[3],
                            (string)reader[4],
                            StoreProducts((int)reader[0]),
                            StoreCategories((int)reader[0])
                        );
                    svm = tempSvm;
                }
            }
            return svm;
        }
        private Account StoreAccount(int? storeId)
        {
            Account account = new Account();

            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "St_Account",
                CommandType = System.Data.CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("@storeId", storeId);
            sqlConnection.Open();
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    Account tempAcc = new Account(
                        (int)reader["Id"],
                        (string)reader["Email"],
                        (string)reader["Username"]
                        );
                    account = tempAcc;
                }
            }
            return account;
        }
        private List<Category> StoreCategories(int? storeId)
        {
            List<Category> storeCategories = new List<Category>();
            
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "St_Categories",
                CommandType = System.Data.CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("@storeId", storeId);
            sqlConnection.Open();
            using(var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    storeCategories.Add(new Category((int)reader["Id"], (string)reader["Name"]));
                }
            }
            sqlConnection.Close();
            return storeCategories;
        }
        private List<Product> StoreProducts(int? storeId)
        {
            List<Product> storeProducts = new List<Product>();

            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "St_Products",
                CommandType = System.Data.CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("@storeId", storeId);
            sqlConnection.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    storeProducts.Add(new Product(
                        (int)reader["Id"],
                        (string)reader["Name"],
                        (string)reader["Description"],
                        (decimal)reader["Price"],
                        (string)reader["MediaUrl"],
                        new Category((int)reader[1]),
                        (int)reader["Store_Id"])
                        );
                }
            }
            sqlConnection.Close();
            return storeProducts;
        }
    }
}
