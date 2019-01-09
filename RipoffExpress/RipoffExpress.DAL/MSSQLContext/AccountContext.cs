using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using RipoffExpress.DAL.Interfaces;
using RipoffExpress.Models;

namespace RipoffExpress.DAL
{
    public class AccountContext : IAccountContext
    {
        private readonly string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RipOffExpress;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

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

            return (int)cmd.ExecuteScalar() >= 1;
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

            return (int)cmd.ExecuteScalar() >= 1;
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

            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    AccountDetails tempAcc = new AccountDetails(
                        (int)reader["Id"],
                        (string)reader["Username"],
                        (string)reader["Email"],
                        (string)reader["Password"],
                        FillAddressBook(Id));
                    accountDetails = tempAcc;
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
        private List<ShippingAddress> FillAddressBook(int? Id)
        {
            List<ShippingAddress> AddressBook = new List<ShippingAddress>();
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "Ac_FillAddressBook",
                CommandType = CommandType.StoredProcedure,
                Connection = sqlConnection
            };
            cmd.Parameters.AddWithValue("@Id", Id);
            sqlConnection.Open();
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    bool Default;
                    if ((int)reader["Default"] == 1)
                    {
                        Default = true;
                    }
                    else
                    {
                        Default = false;
                    }
                    AddressBook.Add(new ShippingAddress(
                        (int)reader["Id"],
                        (string)reader["Address"],
                        (string)reader["PostalCode"],
                        (string)reader["City"],
                        (string)reader["Province"],
                        (string)reader["Country"],
                        (string)reader["PhoneNumber"],
                        Default)
                        );
                }
            }
            return AddressBook;
        }
    }
}
