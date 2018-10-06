using System;
using System.Data;
using System.Data.SqlClient;
using RipoffExpress.Models.Models;

namespace RipoffExpress.DAL.Account
{
    public class AccountContext
    {
        private readonly string ConnectionString = @"Data Source=s2ripoffexpress.database.windows.net;Initial Catalog=RipOffExpress;User ID=Admin!;Password=QMXS6GQVER7R!;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

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
            //cmd.Parameters.AddWithValue("@CreationDate", a.CreationDate);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return true;
        }
    }
}
