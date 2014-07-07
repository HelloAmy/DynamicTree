using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Better.Amy.IDao;
using DynamicTree.Models;

namespace DynamicTree.Controllers
{
    public class DynamicTreeController : Controller
    {
        private BTree bll = new BTree();

        public ActionResult Index()
        {
            List<MTree> list = this.bll.QueryAllTree();

            return View(list);
        }

    }
}
