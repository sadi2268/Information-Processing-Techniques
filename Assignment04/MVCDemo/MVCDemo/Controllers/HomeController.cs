using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;
using PagedList;
using PagedList.Mvc;


namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        private SampleDBContext db = new SampleDBContext();

        // GET: Home
        public ActionResult Index(string name, string description, int? page, string sortBy)
        {
            ViewBag.SortNameParameter = string.IsNullOrEmpty(sortBy) ? "Name desc" : "";
            ViewBag.SortPriceParameter = sortBy == "Price" ? "Price desc" : "Price";

            var products = db.Products.AsQueryable();

            products = products.Where(p => p.ProductName.StartsWith(name) && p.ProductDescription.Contains(description) || name == null);

            switch(sortBy)
            {
                case "Name desc":
                    products = products.OrderByDescending(p => p.ProductName);
                    break;
                case "Price desc":
                    products = products.OrderByDescending(p => p.ProductPrice);
                    break;
                case "Price":
                    products = products.OrderBy(p => p.ProductPrice);
                    break;
                default:
                    products = products.OrderBy(p => p.ProductName);
                    break;
            }
            return View(products.ToPagedList(page ?? 1, 10));
        }


        /*

        // GET: Home/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            ViewBag.PrimaryCategoryId = new SelectList(db.Categories, "CategoryId", "CategoryName");
            return View();
        }

        // POST: Home/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductId,ProductName,PrimaryCategoryId,ProductDescription,Active,ProductPrice,OtherAttributes")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PrimaryCategoryId = new SelectList(db.Categories, "CategoryId", "CategoryName", product.PrimaryCategoryId);
            return View(product);
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.PrimaryCategoryId = new SelectList(db.Categories, "CategoryId", "CategoryName", product.PrimaryCategoryId);
            return View(product);
        }

        // POST: Home/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductId,ProductName,PrimaryCategoryId,ProductDescription,Active,ProductPrice,OtherAttributes")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PrimaryCategoryId = new SelectList(db.Categories, "CategoryId", "CategoryName", product.PrimaryCategoryId);
            return View(product);
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    */
    }
}
