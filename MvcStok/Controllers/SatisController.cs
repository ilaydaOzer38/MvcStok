using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;
using MvcStok.Models.Entity;


namespace MvcStok.Controllers
{
    public class SatisController : Controller
    {
        // GET: Satis
        MvcDbStokEntities1 db = new MvcDbStokEntities1();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult YeniSatis()
        {
            return View();

        }

        [HttpPost]
        public ActionResult YeniSatis(TBLSATISLAR p)
        {
            db.TBLSATISLAR.Add(p);
            db.SaveChanges();
            return View("Index");


        }
        
    }
}