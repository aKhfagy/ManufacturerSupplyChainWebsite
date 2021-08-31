using Manufacturer.IBL;
using Manufacturer.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace ManufacturerWebAPI.Controllers
{
    public class Requsets1Controller : ApiController
    {
        
        // GET: Default140
        private IOrderRepository iOrderRepository;

        public Requsets1Controller(IOrderRepository _iOrderRepository)
        {
            iOrderRepository = _iOrderRepository;
        }

        // GET: api/Requsets1
        public IEnumerable<OrderModel> GetRequsets()
        {

            IEnumerable<OrderModel> listOfOrderModels = iOrderRepository.GetAllOrders();

            return listOfOrderModels;
        }

        // GET: api/Requsets1/5
       
        //public IHttpActionResult GetRequset(int id)
        //{
           

        //    return Ok(requset);
        //}

        //// PUT: api/Requsets1/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutRequset(int id, Requset requset)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != requset.CompanyID)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(requset).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!RequsetExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/Requsets1
        //[ResponseType(typeof(Requset))]
        //public IHttpActionResult PostRequset(Requset requset)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Requsets.Add(requset);

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (RequsetExists(requset.CompanyID))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtRoute("DefaultApi", new { id = requset.CompanyID }, requset);
        //}

        //// DELETE: api/Requsets1/5
        //[ResponseType(typeof(Requset))]
        //public IHttpActionResult DeleteRequset(int id)
        //{
        //    Requset requset = db.Requsets.Find(id);
        //    if (requset == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Requsets.Remove(requset);
        //    db.SaveChanges();

        //    return Ok(requset);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool RequsetExists(int id)
        //{
        //    return db.Requsets.Count(e => e.CompanyID == id) > 0;
        //}
    }
}