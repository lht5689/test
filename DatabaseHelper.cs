using System;
using System.Data;
using System.Data.SqlClient;

namespace GameManagementSystem
{
    public class DatabaseHelper
    {
        // 数据库连接字符串，根据实际情况替换

        private readonly string connectionString = @"Data Source=125.76.225.83;Initial Catalog=GameManagement;User ID=sa;Password=GuoFeng@25331595";


        /// <summary>
        /// 执行查询语句，返回结果集
        /// </summary>
        /// <param name="query">SQL 查询语句</param>
        /// <returns>DataTable 对象</returns>
        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("数据库查询失败: " + ex.Message);
                }
            }

            return dataTable;
        }

        /// <summary>
        /// 执行非查询语句（INSERT、UPDATE、DELETE）
        /// </summary>
        /// <param name="query">SQL 语句</param>
        public void ExecuteNonQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("数据库操作失败: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// 执行参数化查询，返回结果集
        /// </summary>
        /// <param name="query">SQL 查询语句</param>
        /// <param name="parameters">SQL 参数</param>
        /// <returns>DataTable 对象</returns>
        public DataTable ExecuteQuery(string query, SqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("数据库查询失败: " + ex.Message);
                }
            }

            return dataTable;
        }

        /// <summary>
        /// 执行参数化非查询语句（INSERT、UPDATE、DELETE）
        /// </summary>
        /// <param name="query">SQL 语句</param>
        /// <param name="parameters">SQL 参数</param>
        public void ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("数据库操作失败: " + ex.Message);
                }
            }
        }
    }
}
