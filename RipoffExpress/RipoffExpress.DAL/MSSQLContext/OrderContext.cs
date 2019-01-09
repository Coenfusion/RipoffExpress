using RipoffExpress.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RipoffExpress.DAL
{
    public class OrderContext : IOrderContext
    {
        private readonly string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RipOffExpress;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Order> OrderOverview(int? id)
        {
            List<Order> Orders = new List<Order>();

            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Or_Overview",
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("@Id", id);
            sqlConnection.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Enum.TryParse(reader[0].ToString(), out OrderStatus status);
                    Order o = new Order
                    {
                        OrderStatus = status,
                        Id = (int)reader[1],
                        OrderTime = (string)reader[2]
                    };
                    o.OrderItems = FillOrder(o.Id);
                    Orders.Add(o);
                }
            }
            sqlConnection.Close();
            return Orders;
        }
        private List<ProductModelView> FillOrder(int? id)
        {
            List<ProductModelView> Products = new List<ProductModelView>();

            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Or_FillOrder",
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("@OrderId", id);
            sqlConnection.Open();
            using(var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Products.Add(new ProductModelView((string)reader["MediaUrl"], (string)reader["Name"],(string)reader["Description"], (decimal)reader["Price"], (int)reader["Id"]));
                }
            }
            return Products;
        }
        public Order OrderByStatus(int? Id, OrderStatus status)
        {
            Order o = new Order();
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Or_ByStatus",
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Status", (int)status);
            sqlConnection.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    o.Id = (int)reader[5];
                    o.OrderStatus = status;
                    o.OrderItems.Add(new ProductModelView((string)reader["MediaUrl"], (string)reader["Name"], (string)reader["Description"], (decimal)reader["Price"], (int)reader[4]));
                }
            }
            return o;
        }

        public void RemoveProductFromOrder(int? productId, int? orderId)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Or_RemoveProduct",
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("@productId", productId);
            cmd.Parameters.AddWithValue("@orderId", orderId);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
