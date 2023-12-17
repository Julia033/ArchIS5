using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6.Controllers
{
    class DatabaseController
    {
        public void Insert(Models.House participants)
        {
            using (Database.HouseDbContext db = new Database.HouseDbContext())
            {
                db.Participants.Add(participants);
                db.SaveChanges();
            }
        }
        public List<Models.House> SelectAll()
        {
            List<Models.House> participants1;
            using (Database.HouseDbContext db = new Database.HouseDbContext())
            {
                participants1 = db.Participants.ToList();
            }
            return participants1;
        }
        public List<Models.House> House (Guid? CityID)
        {
            List<Models.House> house;
            using (Database.HouseDbContext db = new Database.HouseDbContext())
            {
                house = db.Cities.Where(s => s.Id == CityID)
                    .Include(s => s.Houses)
                    .First().Houses.ToList();
            }
            return house;
        }
        public List<Models.City> SelectAllCity()
        {
            List<Models.City> city;
            using (Database.HouseDbContext db = new Database.HouseDbContext())
            {
                city = db.Cities.ToList();
            }
            return city;
        }
    }
}
