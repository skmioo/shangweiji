using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuoZhouControl.DAL
{
	public static class MySQLHelper
	{
		private static string ConStr = ConfigurationManager.ConnectionStrings["ConStr"].ToString();


        /// <summary>
        /// 返回结果集
        /// 用于执行一个 SQL 查询并返回一个 SqlDataReader 对象，该对象可以用于读取查询结果的行和列。
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static MySqlDataReader GetReader(string sql)
        {
            MySqlConnection DBConnection = new MySqlConnection(ConStr);
            MySqlCommand cmd = new MySqlCommand(sql, DBConnection);
            try
            {
                DBConnection.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                DBConnection.Close();
                throw ex;
            }
        }

        /// 执行增删改
        /// ExecuteNonQuery 是用来执行 SQL 语句并返回受影响的行数的方法。
        /// 它通常用于执行 INSERT、UPDATE、DELETE 等非查询操作。
        /// 当执行 INSERT 操作时，ExecuteNonQuery 方法返回插入的记录数；
        /// 执行 UPDATE 和 DELETE 操作时，受影响的行数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int Update(string sql)
        {
            MySqlConnection DBConnection = new MySqlConnection(ConStr);
            MySqlCommand cmd = new MySqlCommand(sql, DBConnection);
            try
            {
                DBConnection.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DBConnection.Close();
            }
        }


        /// <summary>
        /// 返回数据集
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql)
        {
            MySqlConnection DBConnection = new MySqlConnection(ConStr);
            MySqlCommand cmd = new MySqlCommand(sql, DBConnection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                DBConnection.Open();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                DBConnection.Close();
            }
        }




        #region 启用事务执行多条SQL语句
        /// <summary>
        /// 启用事务执行多条SQL语句
        /// </summary>
        /// <param name="sqlList"></param>
        /// <returns></returns>
        public static bool UpdateByTran(List<string> sqlList)
        {
            MySqlConnection DBConnection = new MySqlConnection(ConStr);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = DBConnection;
            try
            {
                DBConnection.Open();
                cmd.Transaction = DBConnection.BeginTransaction();//开启事务
                foreach (string itemsql in sqlList)
                {
                    cmd.CommandText = itemsql;
                    cmd.ExecuteNonQuery();
                }
                cmd.Transaction.Commit();//提交事务
                return true;
            }
            catch (Exception ex)
            {
                if (cmd.Transaction != null)
                    cmd.Transaction.Rollback();//回滚事务
                throw new Exception("调用事务方法时出现错误：" + ex.Message);
            }
            finally
            {
                if (cmd.Transaction != null)
                    cmd.Transaction = null;//清空事务
                DBConnection.Close();

            }
        }
        #endregion

        #region 错误信息写入日志
        /// <summary>
        /// 将错误信息写入日志文件
        /// </summary>
        /// <param name="msg"></param>
        private static void WriteLog(string msg)
        {
            FileStream fs = new FileStream("Log.text", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("[{0}]  错误信息：{1}", DateTime.Now.ToString(), msg);
            sw.Close();
            fs.Close();
        }
        #endregion

        #region 执行带参数的SQL语句
        /// <summary>
        /// 执行增删改
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int Update(string sql, MySqlParameter[] param)
        {
            MySqlConnection DBConnection = new MySqlConnection(ConStr);
            MySqlCommand cmd = new MySqlCommand(sql, DBConnection);
            try
            {
                DBConnection.Open();
                cmd.Parameters.AddRange(param);//添加参数
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                WriteLog("执行Update(string sql)方法发生错误，错误日志：" + ex.Message);
                throw;
            }
            finally
            {
                DBConnection.Close();
            }
        }
        /// <summary>
        /// 返回单一结果
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetSingleResult(string sql, SqlParameter[] param)
        {
            MySqlConnection DBConnection = new MySqlConnection(ConStr);
            MySqlCommand cmd = new MySqlCommand(sql, DBConnection);
            try
            {
                DBConnection.Open();
                cmd.Parameters.AddRange(param);//添加参数
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                WriteLog("执行GetSingleResult(string sql)方法发生错误，错误日志：" + ex.Message);
                throw;
            }
            finally
            {
                DBConnection.Close();
            }
        }
        /// <summary>
        /// 返回数据集
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static MySqlDataReader GetReader(string sql, SqlParameter[] param)
        {
            MySqlConnection DBConnection = new MySqlConnection(ConStr);
            MySqlCommand cmd = new MySqlCommand(sql, DBConnection);
            try
            {
                DBConnection.Open();
                cmd.Parameters.AddRange(param);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                WriteLog("执行GetReader(string sql)方法发生错误，错误日志：" + ex.Message);
                DBConnection.Close();
                throw ex;
            }

        }
        #endregion

        #region 写入日志
        public static void Log(string info, int type, string user)
        {
            string sql = "Insert into SysLog(LogTime,LogInfo,User,LogType) values('{0}','{1}','{2}',{3})";

            sql = string.Format(sql, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), info, user, type);

            Update(sql);
        }
        #endregion
    }
}
