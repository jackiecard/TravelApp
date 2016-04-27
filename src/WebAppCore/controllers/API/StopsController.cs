using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebAppCore.models;
using AutoMapper;
using WebAppCore.ViewModels;
using YourAppName.Services;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppCore.controllers.API
{
    [Route("api/[controller]/tripName")]
    public class StopsController : Controller
    {
        public TripRepository db = new TripRepository(new TripContext());
        public CoordinateService coordService = new CoordinateService();

        // GET: api/values
        [HttpGet]
        public JsonResult Get(string tripName)
        {
            var stop = db.GetStops(tripName);

            var results = Mapper.Map<IEnumerable<TripViewModel>>(stop);
            return Json(results);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task<JsonResult> Post(StopViewModel stop)
        {
            var newStop = Mapper.Map<Stop>(stop);
            var longlat = await coordService.Lookup(newStop.Name);
            if (longlat.Success)
            {
                db.AddStop(newStop);

            }
            return Json(newStop);
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
