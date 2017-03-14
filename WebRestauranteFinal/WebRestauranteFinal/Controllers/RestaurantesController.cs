using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebRestauranteFinal;

namespace WebRestauranteFinal.Controllers
{
    public class RestaurantesController : Controller
    {
        private DBRestaurantes db = new DBRestaurantes();

        // GET: Restaurantes
        public ActionResult Index()
        {
            return View(db.Restaurantes.ToList());
        }

        // GET: Restaurantes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Restaurante restaurante = db.Restaurantes.Find(id);
            if (restaurante == null)
            {
                return HttpNotFound();
            }
            return View(restaurante);
        }

        // GET: Restaurantes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Restaurantes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "ID,Nome")] Restaurante restaurante)
        {
            if (ModelState.IsValid)
            {
                db.Restaurantes.Add(restaurante);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(restaurante);
        }




        // GET: Restaurantes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Restaurante restaurante = db.Restaurantes.Find(id);
            if (restaurante == null)
            {
                return HttpNotFound();
            }
            return View(restaurante);
        }

        // POST: Restaurantes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "ID,Nome")] Restaurante restaurante)
        {
            if (ModelState.IsValid)
            {
                db.Entry(restaurante).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(restaurante);
        }

        //// GET: Restaurantes/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Restaurante restaurante = db.Restaurantes.Find(id);
        //    if (restaurante == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(restaurante);
        //}

        // POST: Restaurantes/Delete/5
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            Restaurante restaurante = db.Restaurantes.Find(id);
            db.Restaurantes.Remove(restaurante);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



        // GET: Restaurantes/Search/5
        //public ActionResult Search(String Nome)
        //{
        //    if (String.IsNullOrEmpty(Nome))
        //    {
        //        return View(db.Restaurantes.ToList());
        //        //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    List<Restaurante> restauranteS =   (from r in db.Restaurantes where r.Nome.Contains(Nome) select r).ToList();

        //    if (restauranteS == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(restauranteS);
        //}

        [HttpPost]
        public ActionResult Search([Bind(Include = "ID,Nome")] Restaurante pesquisaRestaurante)
        {
            List<Restaurante> restauranteS;
            if (pesquisaRestaurante == null || string.IsNullOrEmpty(pesquisaRestaurante.Nome))
                restauranteS = db.Restaurantes.ToList();
            else
                restauranteS = (from r in db.Restaurantes where r.Nome.Contains(pesquisaRestaurante.Nome) select r).ToList();

            return Json(restauranteS);

        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
