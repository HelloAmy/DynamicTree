using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Better.Amy.IDao
{
    public interface ITree
    {
        List<MTree> QueryAllTree(IDbConnection conn, IDbTransaction trans);
    }
}
