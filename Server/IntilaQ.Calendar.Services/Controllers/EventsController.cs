using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using IntilaQ.Calendar;
using IntilaQ.Calendar.Services.Models;

namespace IntilaQ.Calendar.Services.Controllers
{
    public class EventsController : ApiController
    {
        private EventsContext db = new EventsContext();

        // GET: api/Events
        public IQueryable<EventItem> GetEventItems()
        {
            return db.EventItems;
        }

        // GET: api/Events/5
        [ResponseType(typeof(EventItem))]
        public IHttpActionResult GetEventItem(int id)
        {
            EventItem eventItem = db.EventItems.Find(id);
            if (eventItem == null)
            {
                return NotFound();
            }

            return Ok(eventItem);
        }

        // PUT: api/Events/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEventItem(int id, EventItem eventItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eventItem.Id)
            {
                return BadRequest();
            }

            db.Entry(eventItem).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Events
        [ResponseType(typeof(EventItem))]
        public IHttpActionResult PostEventItem(EventItem eventItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EventItems.Add(eventItem);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = eventItem.Id }, eventItem);
        }

        // DELETE: api/Events/5
        [ResponseType(typeof(EventItem))]
        public IHttpActionResult DeleteEventItem(int id)
        {
            EventItem eventItem = db.EventItems.Find(id);
            if (eventItem == null)
            {
                return NotFound();
            }

            db.EventItems.Remove(eventItem);
            db.SaveChanges();

            return Ok(eventItem);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EventItemExists(int id)
        {
            return db.EventItems.Count(e => e.Id == id) > 0;
        }
    }
}