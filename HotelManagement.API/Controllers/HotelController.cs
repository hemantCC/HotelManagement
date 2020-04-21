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
using HotelManagement.EntityLayer.BusinessEntity;
using HotelManagement.BusinessLayer;


namespace HotelManagement.API.Controllers
{
    public class HotelController : ApiController
    {
        private IHotelBL _hotelBL;
        public HotelController(IHotelBL hotel)
        {
            _hotelBL = hotel;
        }

        public HttpResponseMessage Post([FromBody]HotelVM HotelObject)
        {
  
            try
            {
                HotelObject.CreatedDate = DateTime.Today;
                HotelObject.UpdatedDate = DateTime.Today;
                int id = _hotelBL.PostHotel(HotelObject);
                 
                var message = Request.CreateResponse(HttpStatusCode.Created, HotelObject);
                message.Headers.Location = new Uri(Request.RequestUri + id.ToString());
                return message;
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
            
        }

        //private DbWebAPIEntities db = new DbWebAPIEntities();

        //// GET: api/Hotel
        //public IQueryable<tblHotel> GettblHotels()
        //{
        //    return db.tblHotels;
        //}

        //// GET: api/Hotel/5
        //[ResponseType(typeof(tblHotel))]
        //public IHttpActionResult GettblHotel(int id)
        //{
        //    tblHotel tblHotel = db.tblHotels.Find(id);
        //    if (tblHotel == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(tblHotel);
        //}

        //// PUT: api/Hotel/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PuttblHotel(int id, tblHotel tblHotel)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != tblHotel.HotelId)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(tblHotel).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!tblHotelExists(id))
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

        //// POST: api/Hotel
        //[ResponseType(typeof(tblHotel))]
        //public IHttpActionResult PosttblHotel(tblHotel tblHotel)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.tblHotels.Add(tblHotel);
        //    db.SaveChanges();

        //    return CreatedAtRoute("DefaultApi", new { id = tblHotel.HotelId }, tblHotel);
        //}

        //// DELETE: api/Hotel/5
        //[ResponseType(typeof(tblHotel))]
        //public IHttpActionResult DeletetblHotel(int id)
        //{
        //    tblHotel tblHotel = db.tblHotels.Find(id);
        //    if (tblHotel == null)
        //    {
        //        return NotFound();
        //    }

        //    db.tblHotels.Remove(tblHotel);
        //    db.SaveChanges();

        //    return Ok(tblHotel);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool tblHotelExists(int id)
        //{
        //    return db.tblHotels.Count(e => e.HotelId == id) > 0;
        //}
    }
}