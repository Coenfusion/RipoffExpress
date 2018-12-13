using System;
using System.Data;
using System.Data.SqlClient;
using RipoffExpress.DAL.Interfaces;
using RipoffExpress.Models;
using RipoffExpress.Models.AccountModels;


namespace RipoffExpress.DAL
{
    public class AccountContext : IAccountContext
    {
        private readonly string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RipOffExpress;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public bool CheckAvailability(Account a)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Ac_Availability",
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("@Email", a.Email);
            cmd.Parameters.AddWithValue("@Username", a.Username);
            sqlConnection.Open();

            if ((int)cmd.ExecuteScalar() >= 1)
            {
                return false;
            }
            return true;
        }
        public void Register(Account a)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Ac_Register",
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
        }
        public bool Login(Account a)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Ac_Login",
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
        public AccountDetails GetAccountDetails(int? Id)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Ac_Details",
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
                    accountDetails.Id = (int)reader["Id"];
                    accountDetails.Username = reader["Username"].ToString();
                    accountDetails.Email = reader["Email"].ToString();

                    shippingAddress.PhoneNumber = reader["PhoneNumber"].ToString();
                    shippingAddress.Address = reader["Address"].ToString();
                    shippingAddress.PostalCode = reader["PostalCode"].ToString();
                    shippingAddress.City = reader["City"].ToString();
                    shippingAddress.Province = reader["Province"].ToString();
                    shippingAddress.Country = reader["Country"].ToString();
                    if((int)reader["Default"] == 1)
                    {
                        shippingAddress.Default = true;
                    }
                    else
                    {
                        shippingAddress.Default = false;
                    }

                    accountDetails.ShippingAddress = shippingAddress;
                }
            }

            return accountDetails;
        }
        public int GetUserId(Account a)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Ac_GetId",
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("Email", a.Email);
            sqlConnection.Open();
            int UserId = 0;
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    UserId = (int)reader["Id"];
                }
            }
            return UserId;
        }
        public void SaveChanges(AccountChanges a, int? Id)
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Ac_EditDetails",
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@Email", a.Email);
            cmd.Parameters.AddWithValue("@Username", a.Username);
            cmd.Parameters.AddWithValue("@NewPassword", a.NewPassword);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
