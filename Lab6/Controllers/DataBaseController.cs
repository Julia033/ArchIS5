using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Controllers
{
    public class DataBaseController
    {
        public void Insert(Models.House3 participants)
        {
            using (DataBase.House3DbContext db = new DataBase.House3DbContext())
            {
                db.Participants.Add(participants);
                db.SaveChanges();
            }
        }

        public List<Models.House3> SelectAll()
        {
            List<Models.House3> participants1;
            using (DataBase.House3DbContext db = new DataBase.House3DbContext())
            {
                participants1 = db.Participants.ToList();
            }
            return participants1;
        }
    }
}
