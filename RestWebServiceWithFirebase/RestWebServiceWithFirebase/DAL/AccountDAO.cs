using RestWebServiceWithFirebase.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RestWebServiceWithFirebase.DAL
{
    public class AccountDAO
    {
        public static String connectStr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        public static List<Account> selectAll()
        {

            SqlConnection conn = new SqlConnection(connectStr);
            conn.Open();
            String queryStr = @"SELECT * FROM sc_account";
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            DbDataReader reader = cmd.ExecuteReader();
            List<Account> accounts = new List<Account>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Account account = new Account()
                    {
                        Id = reader.GetInt32(0),
                        Username = reader.GetString(1),
                        Password = reader.GetString(2)
                    };
                    accounts.Add(account);
                }
            }

            conn.Close();
            return accounts;
        }

        public static List<Account> searchByName(String keywords)
        {
            SqlConnection conn = new SqlConnection(connectStr);
            conn.Open();
            String queryStr = @"SELECT * FROM sc_account WHERE username = '" + keywords + "' ";
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            DbDataReader reader = cmd.ExecuteReader();
            List<Account> accounts = new List<Account>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Account account = new Account()
                    {
                        Id = reader.GetInt32(0),
                        Username = reader.GetString(1),
                        Password = reader.GetString(2)
                    };
                    accounts.Add(account);
                }
            }

            conn.Close();
            return accounts;
        }

        public static Account searchById(String id)
        {
            SqlConnection conn = new SqlConnection(connectStr);
            conn.Open();
            String queryStr = @"SELECT * FROM sc_account WHERE id = '" + id + "' ";
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            DbDataReader reader = cmd.ExecuteReader();
            Account accountTemp = new Account();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Account account = new Account()
                    {
                        Id = reader.GetInt32(0),
                        Username = reader.GetString(1),
                        Password = reader.GetString(2)
                    };
                    accountTemp = account;
                }
            }

            conn.Close();
            return accountTemp;
        }

        public static Boolean updateById(Account account)
        {
            SqlConnection conn = new SqlConnection(connectStr);
            conn.Open();
            String queryStr = @"UPDATE sc_account SET username=@username,password=@password WHERE id = @id ";
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@username", account.Username);
            cmd.Parameters.AddWithValue("@password", account.Password);
           
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters["@id"].Value = account.Id;

            Int32 rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("RowsAffected: {0}", rowsAffected);

            return rowsAffected > 0;
        }

        public static Boolean Insert(Account account)
        {
            SqlConnection conn = new SqlConnection(connectStr);
            
            try {
                List<Account> accountTemp=searchByName(account.Username).ToList<Account>();
                if (accountTemp.Count == 0)
                {
                    conn.Open();
                    String queryStr = @"INSERT INTO sc_account(username,password) VALUES (@username,@password)";
                    SqlCommand cmd = new SqlCommand(queryStr, conn);

                    cmd.Parameters.AddWithValue("@username", account.Username);
                    cmd.Parameters.AddWithValue("@password", account.Password);

                    cmd.Parameters.Add("@id", SqlDbType.Int);
                    cmd.Parameters["@id"].Value = account.Id;

                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine("RowsAffected: {0}", rowsAffected);
                    conn.Close();
                    return rowsAffected > 0;
                }
                else
                {
                    return false;
                }
                

            }
            catch(Exception)
            {
                conn.Close();
                return false;
            }
            
            return false;
        }

        public static Boolean deleteById(String id)
        {
            SqlConnection conn = new SqlConnection(connectStr);
            conn.Open();
            String queryStr = @"Delete from sc_account where id = @id";
            SqlCommand cmd = new SqlCommand(queryStr, conn);

            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters["@id"].Value = id;

            Int32 rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("RowsAffected: {0}", rowsAffected);

            return rowsAffected > 0;
        }
    }
}