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
                    Order o = new Order((int)reader[1], status, (string)reader[2], FillOrder((int)reader[1]));
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
            Order order = new Order();
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
                    Order tempOrder = new Order((int)reader[0], status, (string)reader[2], FillOrder((int)reader[0]));
                    order = tempOrder;
                }
            }
            return order;
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
        public Order OrderById(int? orderId)
        {
            Order order = new Order();
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Or_ById",
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("@Id", orderId);
            sqlConnection.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Order tempOrder = new Order((int)reader[0], (OrderStatus)reader[1], (string)reader[2], FillOrder((int)reader[0]));
                    order = tempOrder;
                }
            }
            return order;
        }
        public void OrderFinalization(int? orderId)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Or_Finalize",
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("@orderId", orderId);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
