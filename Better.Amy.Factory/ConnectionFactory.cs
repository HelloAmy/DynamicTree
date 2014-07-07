using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;


namespace Better.Amy.Factory
{
    /// <summary>
    /// 数据库连接工程
    /// </summary>
    public class ConnectionFactory
    {
        /// <summary>
        /// 获取Amydb读库连接
        /// </summary>
        /// <returns>mysql连接</returns>
        public static IDbConnection GetAmyDbReadConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["AmydbRead"].ToString();
            return new MySqlConnection(connectionString);
        }
    }
}
