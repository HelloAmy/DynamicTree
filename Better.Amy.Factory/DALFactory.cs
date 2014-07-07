using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Better.Amy.IDao;
using Better.Amy.MysqlDao;

namespace Better.Amy.Factory
{
    public class DALFactory
    {
        public static ITree GetTreeDao()
        {
            return new DTree();
        }
    }
}
