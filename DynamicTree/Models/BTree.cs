using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Better.Amy.Factory;
using Better.Amy.IDao;
using System.Data;

namespace DynamicTree.Models
{
    public class BTree
    {
        private ITree dao = DALFactory.GetTreeDao();

        public List<MTree> QueryAllTree()
        {
            List<MTree> list = new List<MTree>();
            IDbConnection conn = ConnectionFactory.GetAmyDbReadConnection();
            ITree IDAL = DALFactory.GetTreeDao();

            try
            {
                list = this.dao.QueryAllTree(conn, null);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            return list;
        }

 
    }
}