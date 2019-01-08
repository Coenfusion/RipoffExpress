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
                    Enum.TryParse(reader[3].ToString(), out OrderStatus status);
                    Order o = new Order
                    {
                        Id = (int)reader[5],
                        OrderStatus = status
                    };
                    o.OrderItems.Add(new ProductModelView((string)reader[0], (string)reader[1], (decimal)reader[2], (int)reader[3]));
                    Orders.Add(o);
                }
            }
            sqlConnection.Close();
            return Orders;
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
                    o.Id = (int)reader[3];
                    o.OrderStatus = status;
                    o.OrderItems.Add(new ProductModelView((string)reader[0], (string)reader[1], (decimal)reader[2], (int)reader[4]));
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
