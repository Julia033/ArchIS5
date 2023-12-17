using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6.Models
{
    class City
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
       
        public ICollection<House> Houses { get; set; }
        public City()
        {
            Houses = new List<House>();
        }

    }
}
