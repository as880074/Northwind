using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleNorthwind.Controllers
{
    public class NtdController : Controller
    {
        // GET: Ntd
        public ActionResult Index()
        {
            return View();
        }

        // GET: Ntd/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ntd/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ntd/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ntd/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ntd/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ntd/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ntd/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
