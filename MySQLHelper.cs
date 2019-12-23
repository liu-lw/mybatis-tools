﻿/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2019/12/22
 * Time: 12:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace tools
{
	/// <summary>
    /// The SQLHelper class is intended to encapsulate high performance,
    /// scalable best practices for common uses of SqlClient.
    /// </summary>
    public abstract class MySQLHelper
    {
        #region [ Connection ]
        public static string connectionString = ConfigurationSettings.AppSettings["mysqlConnStr"];
        public static MySqlConnection GetConnection 
        {
            get
            {
                return new MySqlConnection(connectionString);
            }
        }
        #endregion
 
        #region [ ExecuteNonQuery ]
        /// <summary>
        /// 普通SQL语句执行增删改
        /// </summary>
        /// <param name="cmdText">SQL语句</param>
        /// <param name="commandParameters">可变参数</param>
        /// <returns>受影响行数</returns>
        public static int ExecuteNonQuery(string cmdText, params MySqlParameter[] commandParameters)
        {
            return ExecuteNonQuery(cmdText, CommandType.Text, commandParameters);
        }
        /// <summary>
        /// 存储过程执行增删改
        /// </summary>
        /// <param name="cmdText">存储过程</param>
        /// <param name="commandParameters">可变参数</param>
        /// <returns>受影响行数</returns>
        public static int ExecuteNonQueryByProc(string cmdText, params MySqlParameter[] commandParameters)
        {
            return ExecuteNonQuery(cmdText, CommandType.StoredProcedure, commandParameters);
        }
        /// <summary>
        /// 执行增删改
        /// </summary>
        /// <param name="cmdText">命令字符串</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="commandParameters">可变参数</param>
        /// <returns>受影响行数</returns>
        public static int ExecuteNonQuery(string cmdText, CommandType cmdType, params MySqlParameter[] commandParameters)
        {
            int result = 0;
 
            using (MySqlConnection conn = GetConnection)
            {
                try
                {
                    MySqlCommand command = new MySqlCommand();
                    PrepareCommand(command, conn, cmdType, cmdText, commandParameters);
                    result = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally 
                {
                    if(conn!=null && conn.State!= ConnectionState.Closed)
                        conn.Close();
                }
            }
            return result;
        }
        #endregion
 
        #region [ ExecuteReader ]
        /// <summary>
        /// SQL语句得到 MySqlDataReader 对象
        /// </summary>
        /// <param name="cmdText">命令字符串</param>
        /// <param name="commandParameters">可变参数</param>
        /// <returns>MySqlDataReader 对象</returns>
        public static MySqlDataReader ExecuteReader(string cmdText, params MySqlParameter[] commandParameters)
        {
            return ExecuteReader(cmdText, CommandType.Text, commandParameters);
        }
        /// <summary>
        /// 存储过程得到 MySqlDataReader 对象
        /// </summary>
        /// <param name="cmdText">命令字符串</param>
        /// <param name="commandParameters">可变参数</param>
        /// <returns>MySqlDataReader 对象</returns>
        public static MySqlDataReader ExecuteReaderByProc(string cmdText, params MySqlParameter[] commandParameters)
        {
            return ExecuteReader(cmdText, CommandType.StoredProcedure, commandParameters);
        }
        /// <summary>
        /// 得到 MySqlDataReader 对象
        /// </summary>
        /// <param name="cmdText">命令字符串</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="commandParameters">可变参数</param>
        /// <returns>MySqlDataReader 对象</returns>
        public static MySqlDataReader ExecuteReader(string cmdText, CommandType cmdType, params MySqlParameter[] commandParameters)
        {
            MySqlDataReader result = null;
 
            using (MySqlConnection conn = GetConnection)
            {
                try
                {
                    MySqlCommand command = new MySqlCommand();
                    PrepareCommand(command, conn, cmdType, cmdText, commandParameters);
                    result = command.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    if (conn != null && conn.State != ConnectionState.Closed)
                        conn.Close();
                }
            }
 
            return result;
        }
        #endregion
 
        #region [ ExecuteDataSet ]
        /// <summary>
        /// 执行SQL语句, 返回DataSet
        /// </summary>
        /// <param name="cmdText">命令字符串</param>
        /// <param name="commandParameters">可变参数</param>
        /// <returns> DataSet </returns>
        public static DataSet ExecuteDataSet(string cmdText, params MySqlParameter[] commandParameters)
        {
            return ExecuteDataSet(cmdText, CommandType.Text, commandParameters);
        }
 
        /// <summary>
        /// 执行存储过程, 返回DataSet
        /// </summary>
        /// <param name="cmdText">命令字符串</param>
        /// <param name="commandParameters">可变参数</param>
        /// <returns> DataSet </returns>
        public static DataSet ExecuteDataSetByProc(string cmdText, params MySqlParameter[] commandParameters)
        {
            return ExecuteDataSet(cmdText, CommandType.StoredProcedure, commandParameters);
        }
 
        /// <summary>
        /// 返回DataSet
        /// </summary>
        /// <param name="cmdText">命令字符串</param>
        /// <param name="cmdType">命令类型</param>
        /// <param name="commandParameters">可变参数</param>
        /// <returns> DataSet </returns>
        public static DataSet ExecuteDataSet(string cmdText, CommandType cmdType, params MySqlParameter[] commandParameters)
        {
            DataSet result = null;
 
            using (MySqlConnection conn = GetConnection)
            {
                try
                {
                    MySqlCommand command = new MySqlCommand();
                    PrepareCommand(command, conn, cmdType, cmdText, commandParameters);
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = command;
                    result = new DataSet();
                    adapter.Fill(result);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    if (conn != null && conn.State != ConnectionState.Closed)
                        conn.Close();
                }
            }
 
            return result;
        }
        #endregion
 

        #region [ PrepareCommand ]
        /// <summary>
        /// Command对象执行前预处理
        /// </summary>
        /// <param name="command"></param>
        /// <param name="connection"></param>
        /// <param name="trans"></param>
        /// <param name="cmdType"></param>
        /// <param name="cmdText"></param>
        /// <param name="commandParameters"></param>
        private static void PrepareCommand(MySqlCommand command, MySqlConnection connection, CommandType cmdType, string cmdText, MySqlParameter[] commandParameters)
        {
            try
            {
                if (connection.State != ConnectionState.Open) connection.Open();
 
                command.Connection = connection;
                command.CommandText = cmdText;
                command.CommandType = cmdType;
                //command.CommandTimeout = 3600;    //此处请自定义
 
                //if (trans != null) command.Transaction = trans;
 
                if (commandParameters != null)
                {
                    foreach (MySqlParameter parm in commandParameters)
                        command.Parameters.Add(parm);
                }
            }
            catch
            {
 
            }
        }
        #endregion
    }
}
