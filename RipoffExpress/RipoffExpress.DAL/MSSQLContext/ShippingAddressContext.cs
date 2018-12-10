using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RipoffExpress.Models;

namespace RipoffExpress.DAL
{
    public class ShippingAddressContext : IShippingAddressContext
    {
        private readonly string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RipOffExpress;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<ShippingAddress> GetAddresses(int? Id)
        {
            List<ShippingAddress> allAddresses = new List<ShippingAddress>();
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "GetAddressesProcedure",
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("@Id", Id);
            sqlConnection.Open();
            using(var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    allAddresses.Add(new ShippingAddress(
                        (string)reader["Address"],
                        (string)reader["City"],
                        (string)reader["Province"],
                        (string)reader["PostalCode"],
                        (string)reader["Country"], (string)
                        reader["PhoneNumber"])
                        );
                }
            }
            sqlConnection.Close();
            return allAddresses;
        }
    }
}
