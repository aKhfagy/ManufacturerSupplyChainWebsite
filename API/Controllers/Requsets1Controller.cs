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
using API.Models;

namespace API.Controllers
{
    public class Requsets1Controller : ApiController
    {
        private ManufacturerEntities1 db = new ManufacturerEntities1();

        // GET: api/Requsets1
        public IQueryable<Requset> GetRequsets()
        {
            return db.Requsets;
        }

        // GET: api/Requsets1/5
        [ResponseType(typeof(Requset))]
        public IHttpActionResult GetRequset(int id)
        {
            Requset requset = db.Requsets.Find(id);
            if (requset == null)
            {
                return NotFound();
            }

            return Ok(requset);
        }

        // PUT: api/Requsets1/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRequset(int id, Requset requset)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != requset.CompanyID)
            {
                return BadRequest();
            }

            db.Entry(requset).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RequsetExists(id))
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

        // POST: api/Requsets1
        [ResponseType(typeof(Requset))]
        public IHttpActionResult PostRequset(Requset requset)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Requsets.Add(requset);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (RequsetExists(requset.CompanyID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = requset.CompanyID }, requset);
        }

        // DELETE: api/Requsets1/5
        [ResponseType(typeof(Requset))]
        public IHttpActionResult DeleteRequset(int id)
        {
            Requset requset = db.Requsets.Find(id);
            if (requset == null)
            {
                return NotFound();
            }

            db.Requsets.Remove(requset);
            db.SaveChanges();

            return Ok(requset);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RequsetExists(int id)
        {
            return db.Requsets.Count(e => e.CompanyID == id) > 0;
        }
    }
}