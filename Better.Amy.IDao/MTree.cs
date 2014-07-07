using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Better.Amy.IDao
{
    /// <summary>
    /// 树形model
    /// </summary>
    [Serializable]
    public class MTree
    {
        /// <summary>
        /// 自增长的ID
        /// </summary>
        public int ID
        {
            get;
            set;
        }

        /// <summary>
        /// 名字
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// 父ID
        /// </summary>
        public int PID
        {
            get;
            set;
        }

        /// <summary>
        /// 层级（顶层为第0级）
        /// </summary>
        public int Level
        {
            get;
            set;
        }
    }
}