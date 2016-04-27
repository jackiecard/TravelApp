using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCore.models
{
    public class TripRepository
    {
        private TripContext db { get; set; }

        public TripRepository(TripContext db)
        {
            this.db = db;
        }

        public IEnumerable<Trip> GetAllTrips()
        {
            return db.Trips.OrderBy(t => t.Name).ToList();
        }

        public Trip GetTrip(int id){
            return (Trip)db.Trips.OrderBy(t => t.Name).Where(t => t.ID == id);
        }

        public void SaveTrip(Trip t){
            db.Add(t);
            db.SaveChanges();
        }

        public IEnumerable<Stop> GetStops(string name){
            return db.Stops.OrderBy(t => t.Order).Where(t => t.Name == name).ToList();
        }

        public void AddStop(Stop s){
            db.Stops.Add(s);
            db.SaveChanges();
        }
    }
}
