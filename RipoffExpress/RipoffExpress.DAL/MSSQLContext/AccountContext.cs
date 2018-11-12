using System;
using System.Data;
using System.Data.SqlClient;
using RipoffExpress.DAL.Interfaces;
using RipoffExpress.Models;
using RipoffExpress.Models.AccountModels;


namespace RipoffExpress.DAL.Account
{
    public class AccountContext : IAccountContext
    {
        private readonly string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RipOffExpress;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public bool CheckAvailability(AccountRegister a)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "CheckAvailabilityProcedure",
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("@Email", a.Email);
            sqlConnection.Open();

            if ((int)cmd.ExecuteScalar() >= 1)
            {
                return true;
            }
            return false;
        }
        public bool Register(AccountRegister a)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "RegisterProcedure",
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("@Username", a.Username);
            cmd.Parameters.AddWithValue("@Password", a.Password);
            cmd.Parameters.AddWithValue("@Email", a.Email);
            cmd.Parameters.AddWithValue("@CreationDate", DateTime.Now.ToString());
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }
        public bool Login(AccountLogin a)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "LoginProcedure",
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("@Email", a.Email);
            cmd.Parameters.AddWithValue("@Password", a.Password);
            sqlConnection.Open();

            if ((int)cmd.ExecuteScalar() >= 1)
            {
                return true;
            }
            return false;
        }

        public AccountDetails GetAccountDetails(int Id)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "AccountDetailsProcedure",
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("@Id", Id);
            sqlConnection.Open();

            AccountDetails accountDetails = new AccountDetails();
            ShippingAddress shippingAddress = new ShippingAddress();

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    accountDetails.Username = reader["Username"].ToString();
                    accountDetails.Email = reader["Email"].ToString();

                    shippingAddress.PhoneNumber = reader["PhoneNumber"].ToString();
                    shippingAddress.Address = reader["Address"].ToString();
                    shippingAddress.PostalCode = reader["PostalCode"].ToString();
                    shippingAddress.City = reader["City"].ToString();
                    shippingAddress.Province = reader["Province"].ToString();
                    shippingAddress.Country = reader["Country"].ToString();

                    accountDetails.ShippingAddress = shippingAddress;
                }
            }

            return accountDetails;
        }
    }
}
