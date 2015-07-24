using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IntilaQ.Calendar;
using IntilaQ.Calendar.Services.Models;

namespace IntilaQ.Calendar.Services.Controllers
{
    [Authorize]
    public class EventItemsController : Controller
    {
        private EventsContext db = new EventsContext();

        // GET: EventItems
        public ActionResult Index()
        {
            return View(db.EventItems.ToList());
        }

        // GET: EventItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventItem eventItem = db.EventItems.Find(id);
            if (eventItem == null)
            {
                return HttpNotFound();
            }
            return View(eventItem);
        }

        // GET: EventItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,Description,StartsAt,EndsAt,Location,Organizer,NumberOfAttendees,Color")] EventItem eventItem)
        {
            if (ModelState.IsValid)
            {
                db.EventItems.Add(eventItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eventItem);
        }

        // GET: EventItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventItem eventItem = db.EventItems.Find(id);
            if (eventItem == null)
            {
                return HttpNotFound();
            }
            return View(eventItem);
        }

        // POST: EventItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Description,StartsAt,EndsAt,Location,Organizer,NumberOfAttendees,Color")] EventItem eventItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eventItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eventItem);
        }

        // GET: EventItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventItem eventItem = db.EventItems.Find(id);
            if (eventItem == null)
            {
                return HttpNotFound();
            }
            return View(eventItem);
        }

        // POST: EventItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EventItem eventItem = db.EventItems.Find(id);
            db.EventItems.Remove(eventItem);
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
    }
}
