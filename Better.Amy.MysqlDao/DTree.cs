using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Better.Amy.IDao;
using MySql.Data.MySqlClient;

namespace Better.Amy.MysqlDao
{
    public class DTree : ITree
    {
        public List<MTree> QueryAllTree(IDbConnection conn, IDbTransaction trans)
        {
            List<MTree> list = new List<MTree>();
            string str = @"
                         SELECT id, name, pid, level
                         FROM tb_tree
                        ";

            using (MySqlDataReader reader = MySqlHelper.ExecuteReader(conn.ConnectionString, str))
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MTree model = new MTree();
                        model.ID = Convert.ToInt32(reader["id"].ToString());
                        model.Name = reader["name"] == DBNull.Value ? string.Empty : reader["name"].ToString();
                        model.PID = reader["pid"] == DBNull.Value ? 0 : Convert.ToInt32(reader["pid"].ToString());
                        model.Level = reader["level"] == DBNull.Value ? 0 : Convert.ToInt32(reader["level"].ToString());
                        list.Add(model);
                    }
                }
            }

            return list;
        }
    }
}
