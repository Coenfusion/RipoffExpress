using RipoffExpress.DAL.Interfaces;
using RipoffExpress.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipoffExpress.DAL.MSSQLContext
{
    public class ProductContext : IProductContext
    {
        private readonly string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RipOffExpress;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public IEnumerable<ProductModelView> MostRecentProducts()
        {
            List<ProductModelView> RecentProducts = new List<ProductModelView>();
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Pr_Latest",
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            sqlConnection.Open();
            using(var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    RecentProducts.Add(new ProductModelView(reader["MediaUrl"].ToString(), reader["Name"].ToString(), (decimal)reader["Price"],(int)reader["Id"]));
                }
            }
            return RecentProducts;
        }
        public IEnumerable<Category> LoadCategories()
        {
            List<Category> Categories = new List<Category>();
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Pr_Categories",
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            sqlConnection.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Categories.Add(new Category((int)reader["Id"], (string)reader["Name"]));
                }
            }
            return Categories;
        }
        public IEnumerable<ProductModelView> ProductByCategory(int? Id)
        {
            List<ProductModelView> Products = new List<ProductModelView>();
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Pr_ByCategory",
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("@Id", Id);
            sqlConnection.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Products.Add(new ProductModelView(reader["MediaUrl"].ToString(), reader["Name"].ToString(), (decimal)reader["Price"], (int)reader["Id"]));
                }
            }
            return Products;
        }
        public Product ProductById(int? Id)
        {
            Product product = new Product(); ;
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Pr_ById",
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("@Id", Id);
            sqlConnection.Open();
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    Product tempProduct = new Product(
                        (int)reader["Id"], 
                        (string)reader["Name"], 
                        (string)reader["Description"],
                        (decimal)reader["Price"], 
                        (string)reader["MediaUrl"], 
                        new Category((int)reader["Category_Id"]),
                        (int)reader["Store_Id"]
                        );
                    product = tempProduct;
                }
            }
            return product;
        }
        public IEnumerable<ProductModelView> ProductByCriteria(string criteria)
        {
            List<ProductModelView> Products = new List<ProductModelView>();
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Pr_ByCriteria",
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("@criteria", criteria);
            sqlConnection.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Products.Add(new ProductModelView(reader["MediaUrl"].ToString(), reader["Name"].ToString(), (decimal)reader["Price"], (int)reader["Id"]));
                }
            }
            return Products;
        }
    }
}
