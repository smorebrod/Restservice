using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestServiceprooveiderMeassurement.Model;

namespace RestServiceprooveiderMeassurement.Controllers
{
    public class MeassurementsController : Controller
    {

        private static List<Meassurement> mList = new List<Meassurement>()
        {
         new Meassurement(1,21,22,23),
        new Meassurement(2,22,23,24)

        };

     
      
        

        // GET: Meassurements
        public ActionResult Index()
        {
            return View();
        }

        // GET: Meassurements/Details/allid
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Meassurements/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Meassurements/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: APi/Meassurements/
        public List<Meassurement> get()
        {
            return mList;
        }

        // POST: Meassurements/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Meassurements/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Meassurements/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}