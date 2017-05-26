using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace 图书管理系统
{
    public static class SqlHelper
    {
        // 获取数据库连接   返回连接对象
        private static SqlConnection GetConn()
        {
            return new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["library"].ConnectionString);
        }

        // 执行sql操作   返回是否存在用户
        public static bool IsUserExists(string uId)
        {
            bool isExists = false;

            using (SqlConnection conn = GetConn())
            {
                string sql = "select count(*) from users where uId =@uId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@uId", uId));
                conn.Open();
                int obj = Convert.ToInt32(cmd.ExecuteScalar());// 返回受影响的行数
                if (obj > 0)
                {
                    isExists = true;
                }
            }
            return isExists;
        }

        // 执行sql操作   返回是否存在书籍

        public static bool IsBookExistsWithName(string bName)
        {
            bool isExists = false;

            using (SqlConnection conn = GetConn())
            {
                string sql = "select count(*) from books where bName =@bName";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@bName", bName));
                conn.Open();
                int obj = Convert.ToInt32(cmd.ExecuteScalar());// 返回受影响的行数
                if (obj > 0)
                {
                    isExists = true;
                }
            }
            return isExists;
        }
        public static bool IsBookExistsWithNum(string bNum)
        {
            bool isExists = false;

            using (SqlConnection conn = GetConn())
            {
                string sql = "select count(*) from books where bNum =@bNum";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@bNum", bNum));
                conn.Open();
                int obj = Convert.ToInt32(cmd.ExecuteScalar());// 返回受影响的行数
                if (obj > 0)
                {
                    isExists = true;
                }
            }
            return isExists;
        }


        // 执行 ...   返回受影响行数
        private static int ExecuteNonQuery(string sql, CommandType type, params SqlParameter[] ps)
        {
            int rows = -1;

            using (SqlConnection conn = GetConn())
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = type; // 存储过程 type为StoredProcedure
                cmd.Parameters.AddRange(ps);
                conn.Open();
                rows = cmd.ExecuteNonQuery();
            }

            return rows;
        }
        public static int ExecuteNonQuery(string sql, MyDictionary  dic)
        {
            SqlParameter[] ps = new SqlParameter[dic.Count];
            int index = 0;
            foreach (var item in dic)
            {
                ps[index++] = new SqlParameter(item.Key, item.Value);
            }
            return ExecuteNonQuery(sql, CommandType.Text, ps);
        }
        public static int ExecuteNonQuery(string sql, CommandType type, MyDictionary dic)
        {
            SqlParameter[] ps = new SqlParameter[dic.Count];
            int index = 0;
            foreach (var item in dic)
            {
                ps[index++] = new SqlParameter(item.Key, item.Value);
            }
            return ExecuteNonQuery(sql, type, ps);
        }


        // 执行sql语句   返回首行首列
        public static object ExecuteScalar(string sql)
        {
            object obj = null;
            using (SqlConnection conn = GetConn())
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                obj = cmd.ExecuteScalar();
            }
            return obj;
        }
        public static object ExecuteScalar(string sql, CommandType type, MyDictionary dic)
        {
            object obj = null;
            using (SqlConnection conn = GetConn())
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = type;

                //构造参数
                SqlParameter[] ps = new SqlParameter[dic.Count];
                int index = 0;
                foreach (var item in dic)
                {
                    ps[index++] = new SqlParameter(item.Key, item.Value);
                }
                cmd.Parameters.AddRange(ps);
                //执行命令
                conn.Open();
                obj = cmd.ExecuteScalar();
            }
            return obj;
        }
        public static object ExecuteScalar(string sql, MyDictionary dic)
        {
            return ExecuteScalar(sql, CommandType.Text, dic);
        }



        // 执行查询  返回结果集DataTable  获取列表
        public static DataTable GetList(string sql, MyDictionary  dic)
        {
            // 构造数据表，用于存储查询的数据
            DataTable dt = new DataTable();
            // 创建连接对象
            using (SqlConnection conn = GetConn())
            {
                // 执行命令
                SqlCommand cmd = new SqlCommand(sql, conn);
                // 构造参数
                SqlParameter[] ps = new SqlParameter[dic.Count];
                int index = 0;
                foreach (var item in dic)
                {
                    ps[index++] = new SqlParameter(item.Key, item.Value);
                }
                cmd.Parameters.AddRange(ps);
                // 执行命令
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}
