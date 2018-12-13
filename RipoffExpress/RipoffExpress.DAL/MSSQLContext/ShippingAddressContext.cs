using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using RipoffExpress.Models;

namespace RipoffExpress.DAL
{
    public class ShippingAddressContext : IShippingAddressContext
    {
        private readonly string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RipOffExpress;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //Create, Edit, Delete
        public void CreateNewAddress(ShippingAddress shippingAddress, int? Id)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Ad_Creation",
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("@User_Id", Id);
            cmd.Parameters.AddWithValue("@Address", shippingAddress.Address);
            cmd.Parameters.AddWithValue("@PostalCode",shippingAddress.PostalCode);
            cmd.Parameters.AddWithValue("@City", shippingAddress.City);
            cmd.Parameters.AddWithValue("@Province", shippingAddress.Province);
            cmd.Parameters.AddWithValue("@Country", shippingAddress.Country);
            cmd.Parameters.AddWithValue("@PhoneNumber", shippingAddress.PhoneNumber);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void SaveChanges(ShippingAddress shippingAddress, int? UserId, int? AddressId)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Ad_EditDetails",
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("@UserId", UserId);
            cmd.Parameters.AddWithValue("@AddressId", AddressId);
            cmd.Parameters.AddWithValue("@Address", shippingAddress.Address);
            cmd.Parameters.AddWithValue("@PostalCode", shippingAddress.PostalCode);
            cmd.Parameters.AddWithValue("@City", shippingAddress.City);
            cmd.Parameters.AddWithValue("@Province", shippingAddress.Province);
            cmd.Parameters.AddWithValue("@Country", shippingAddress.Country);
            cmd.Parameters.AddWithValue("@PhoneNumber", shippingAddress.PhoneNumber);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void DeleteAddress(int? AddressId)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Ad_Delete",
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("@AddressId", AddressId);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void SetAsDefault(int? AddressId)
        {
            throw new NotImplementedException();
        }
        //Retrieve info
        public ShippingAddress AddressDetails(int? AddressId)
        {
            ShippingAddress shippingAddress = new ShippingAddress();
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Ad_Details",
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("@AddressId", AddressId);
            sqlConnection.Open();
            using(var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    shippingAddress.Address = (string)reader["Address"];
                    shippingAddress.PostalCode = (string)reader["PostalCode"];
                    shippingAddress.City = (string)reader["City"];
                    shippingAddress.Province = (string)reader["Province"];
                    shippingAddress.Country = (string)reader["Country"];
                    shippingAddress.PhoneNumber = (string)reader["PhoneNumber"];
                }
            }
            sqlConnection.Close();
            return shippingAddress;
        }
        public List<ShippingAddress> GetAddresses(int? Id)
        {
            List<ShippingAddress> allAddresses = new List<ShippingAddress>();
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Ad_Overview",
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("@Id", Id);
            sqlConnection.Open();
            using (var reader = cmd.ExecuteReader())
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

        //Logic 
        public bool CheckForDuplicate(ShippingAddress shippingAddress)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Ad_Duplicate",
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("@Address", shippingAddress.Address);
            cmd.Parameters.AddWithValue("@PostalCode", shippingAddress.PostalCode);
            sqlConnection.Open();
            if ((int)cmd.ExecuteScalar() >= 1)
            {
                return true;
            }
            return false;
        }
       
    }
}
