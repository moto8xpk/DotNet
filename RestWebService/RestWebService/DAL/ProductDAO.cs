using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

using ProductShared;

using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace RestWebService.DAL
{
    public class ProductDAO
    {

        public static String connectStr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        public static List<Product> selectAll()
        {

            SqlConnection conn = new SqlConnection(connectStr);
            conn.Open();
            String queryStr = @"SELECT * FROM sc_product";
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            DbDataReader reader = cmd.ExecuteReader();
            List<Product> products = new List<Product>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Product product = new Product()
                    {
                        id = reader.GetInt32(0),
                        name = reader.GetString(1),
                        cateid = reader.GetInt32(2),
                        price = reader.GetInt32(3),
                        description = reader.GetString(4),
                        imagelink = reader.GetString(5),
                    };
                    products.Add(product);
                }
            }

            conn.Close();
            return products;
        }

        public static List<Product> searchByName(String keywords)
        {
            SqlConnection conn = new SqlConnection(connectStr);
            conn.Open();
            String queryStr = @"SELECT * FROM sc_product WHERE name LIKE '%" + keywords + "%' ";
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            DbDataReader reader = cmd.ExecuteReader();
            List<Product> products = new List<Product>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Product product = new Product()
                    {
                        id = reader.GetInt32(0),
                        name = reader.GetString(1),
                        cateid = reader.GetInt32(2),
                        price = reader.GetInt32(3),
                        description = reader.GetString(4),
                        imagelink = reader.GetString(5),
                    };
                    products.Add(product);
                }
            }

            conn.Close();
            return products;
        }

        public static Product searchById(String id)
        {
            SqlConnection conn = new SqlConnection(connectStr);
            conn.Open();
            String queryStr = @"SELECT * FROM sc_product WHERE id = '" + id + "' ";
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            DbDataReader reader = cmd.ExecuteReader();
            Product productTemp = new Product();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Product product = new Product()
                    {
                        id = reader.GetInt32(0),
                        name = reader.GetString(1),
                        cateid = reader.GetInt32(2),
                        price = reader.GetInt32(3),
                        description = reader.GetString(4),
                        imagelink = reader.GetString(5),
                    };
                    productTemp = product;
                }
            }

            conn.Close();
            return productTemp;
        }

        public static Boolean updateById(Product product)
        {
            SqlConnection conn = new SqlConnection(connectStr);
            conn.Open();
            String queryStr = @"UPDATE sc_product SET name=@name,cateid=@cateid,price=@price,description=@description,imagelink=@imagelink WHERE id = @id ";
            SqlCommand cmd = new SqlCommand(queryStr, conn);
            cmd.Parameters.AddWithValue("@name", product.name);
            cmd.Parameters.AddWithValue("@cateid", product.cateid);
            cmd.Parameters.AddWithValue("@price", product.price);
            cmd.Parameters.AddWithValue("@description", product.description);
            cmd.Parameters.AddWithValue("@imagelink", product.imagelink);
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters["@id"].Value = product.id;

            Int32 rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("RowsAffected: {0}", rowsAffected);

            return rowsAffected > 0;
        }

        public static Boolean Insert(Product product)
        {
            SqlConnection conn = new SqlConnection(connectStr);
            conn.Open();
            String queryStr = @"INSERT INTO sc_product(id,name,cateid,price,description,imagelink) VALUES (@id,@name,@cateid,@price,@description,@imagelink)";
            SqlCommand cmd = new SqlCommand(queryStr, conn);

            cmd.Parameters.AddWithValue("@name", product.name);
            cmd.Parameters.AddWithValue("@cateid", product.cateid);
            cmd.Parameters.AddWithValue("@price", product.price);
            cmd.Parameters.AddWithValue("@description", product.description);
            cmd.Parameters.AddWithValue("@imagelink", product.imagelink);
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters["@id"].Value = product.id;

            Int32 rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("RowsAffected: {0}", rowsAffected);

            return rowsAffected > 0;
        }

        public static Boolean deleteById(String id)
        {
            SqlConnection conn = new SqlConnection(connectStr);
            conn.Open();
            String queryStr = @"Delete from sc_product where id = @id";
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