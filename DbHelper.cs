using GameManagementSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class DbHelper
{
    // 数据库连接字符串
    private static string connectionString = @"Data Source=125.76.225.83;Initial Catalog=GameManagement;User ID=sa;Password=GuoFeng@25331595";

    // ExecuteNonQuery (Insert, Update, Delete)
    public static int ExecuteNonQuery(string sql, SqlParameter[] parameters = null)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteNonQuery();
            }
        }
    }

    // ExecuteScalar (Single value return, e.g., Count, Max)
    public static object ExecuteScalar(string sql, SqlParameter[] parameters = null)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteScalar();
            }
        }
    }

    // ExecuteReader (Select)
    public static DataTable ExecuteReader(string sql, SqlParameter[] parameters = null)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    return dt;
                }
            }
        }
    }

    // 带参数的 ExecuteNonQuery (使用更灵活的 Dictionary 参数)
    public static int ExecuteNonQuery(string sql, Dictionary<string, object> parameters)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                return cmd.ExecuteNonQuery();
            }
        }
    }

    // 带参数的 ExecuteScalar
    public static object ExecuteScalar(string sql, Dictionary<string, object> parameters)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                return cmd.ExecuteScalar();
            }
        }
    }

    // 带参数的 ExecuteReader
    public static DataTable ExecuteReader(string sql, Dictionary<string, object> parameters)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    return dt;
                }
            }
        }
    }
}
