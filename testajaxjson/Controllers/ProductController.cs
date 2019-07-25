using System;
using System.Collections.Generic;
using System.Data;

using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Shooping_19._01._2019.Context;
using testajaxjson.Models;
using System.Data.Entity;
using System.IO;

namespace Shooping_19._01._2019.Controllers
{
    public class ProductsController : Controller
    {
        private DbTestContext db = new DbTestContext();

        // GET: Products
        //public ActionResult Index()
        //{
        //    var products = db.Products.Include(p => p.CategoryName);
        //    return View(products.ToList());
        //}

        //// GET: Products/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Product product = db.Products.Find(id);
        //    if (product == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(product);
        //}

        // GET: Products/Create
        public ActionResult Create()
        {
            using (StreamWriter sw = new StreamWriter(Server.MapPath("~/App_Data/tet.txt"), true))
            {
                var Text = "<h2 style='border:solid 1px black'><p>Notify:</p> Alert</h2>";

                sw.Write(new HtmlString(Text));
            };
            ViewBag.Category = db.Categoryes.ToList();
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product, HttpPostedFileBase a)
        {

            if (ModelState.IsValid)
            {
                
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Category = db.Categoryes.ToList();
            return View(product);
        }


        public ActionResult test()
        {
            ViewBag.Product = db.Products.ToList();
            ViewBag.Category = db.Categoryes.ToList();
            return View();
        }
/// 
/// ////////////////////////////////////////////////////////////////////////////////////////
/// 
///
        [HttpGet]
      public  JsonResult UserTasks(int? id)
        {
            var tasks = db.Products.Where(w => w.CategoryId == id).ToList();
            var tskjason = new List<ProducAjax>();
            for(var i = 0; i < tasks.Count; i++)
            {
                ProducAjax newPR = new ProducAjax();
                newPR.Id = tasks[i].Id;
                newPR.ProductName = tasks[i].ProductName;
                newPR.CategoryId = tasks[i].CategoryId;
                tskjason.Add(newPR);
            }

            /////int ad = 5;
          //  var c = ad.(2);
            return Json(tskjason, JsonRequestBehavior.AllowGet);
        }


      

    }
}
