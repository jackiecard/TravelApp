using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebAppCore.models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppCore.controllers
{
    public class HomeController : Controller
    {

        // GET: /<controller>/
        public IActionResult Index()
        {
            TripRepository tripDb = new TripRepository(new TripContext());
            ViewBag.Trip = new Trip() { Name = "Test", DateCreated = DateTime.Now };
            var trips = tripDb.GetAllTrips();

            return View();
        }

        // GET: /<controller>/
        public IActionResult About()
        {
            return View();
        }

        // GET: /<controller>/
        public IActionResult Contact()
        {
            return View();
        }
    }
}
