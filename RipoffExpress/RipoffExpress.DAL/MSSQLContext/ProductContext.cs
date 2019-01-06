﻿using RipoffExpress.DAL.Interfaces;
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
                    Categories.Add(new Category() {Id = (int)reader["Id"], Name = reader["Name"].ToString()});
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
                    Products.Add(new ProductModelView(reader["MediaUrl"].ToString(), reader["Name"].ToString(), (decimal)reader["Price"],(int)reader["Id"]));
                }
            }
            return Products;
        }
    }
}
