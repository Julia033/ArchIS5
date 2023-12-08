using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Models
{
    class City
    {
        public int Id { get; set; }
        public string NameCity { get; set; }
        public ICollection<House3> house2s { get; set;}
        public City()
        {
            house2s = new List<House3>();
        }

    }
}
