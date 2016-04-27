using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebAppCore.models;
using AutoMapper;
using WebAppCore.ViewModels;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppCore.controllers.API
{
    [Route("api/[controller]")]
    public class TripsController : Controller
    {
        private TripRepository db = new TripRepository(new TripContext());
        
        // GET: api/values
        [HttpGet]
        public JsonResult Get()
        {
            var trips = db.GetAllTrips();
            var results = Mapper.Map<IEnumerable<TripViewModel>>(trips);
            return Json(results);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Trip Get(int id)
        {
            return db.GetTrip(id);
        }

        // POST api/values
        [HttpPost]
        public JsonResult Post(TripViewModel trip)
        {
            var newTrip = Mapper.Map<Trip>(trip);
            newTrip.UserName = "John Doe";
            db.SaveTrip(newTrip);
            return Json(newTrip);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
