using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
///     用于打开或关闭对数据库的连接，不能创建该类的实例化对象且不可继承
/// </summary>
public sealed class VehicleDAO
{
    /// <summary>
    ///     表示数据库连接关闭成功的信息
    /// </summary>
    public static String SUCCESS = "SUCCESS";
    /// <summary>
    ///     表示数据库连接关闭失败的信息
    /// </summary>
    public static String ERROR = "";

    /// <summary>
    ///     默认构造函数，原则上不允许创建该类的对象且不可继承
    /// </summary>
    private VehicleDAO() { }


    /// <summary>
    ///     打开与<paramref name="DbName" />数据库的连接
    /// </summary>
    /// <param name="DbName">需要连接的数据库的名称</param>
    /// <exception cref="SqlException"> 数据库连接被占用或找不到该数据库时将抛出此异常 </exception>
    public static SqlConnection OpenConnection(String DbName = "VehicleManage")
    {



        SqlConnection conn = null;
        string connStr = "Server=(local);Database=" + DbName + "Trusted_Connection=SSPI;";

        conn = new SqlConnection(connStr);
        conn.Open();
        return conn;
    }

    /// <summary>
    ///     关闭数据库连接
    /// </summary>
    /// <param name="conn">待关闭的SqlConnection对象</param>
    /// <returns>一个含有关闭信息的字符串</returns>
    public static String CloseConnection(SqlConnection conn)
    {
        try
        {
            if (conn != null)
            {
                conn.Close();
                return SUCCESS;
            }
            else
            {
                return ERROR = "NULL";
            }
        }
        catch (Exception e)
        {
            return ERROR = e.Message;
        }
    }

}