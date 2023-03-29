using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Apartment
    {
        public int Id { get; set; }

        public int AddressId { get; set; }  

        public ApartmentAddress Address { get; set; }

        public float TotalArea { get; set; }

        public float UsableArea { get; set; }

        public int NumberOfRooms { get; set; }

        // String for now so as not to complicate this
        // simple homework pointlessly
        public string Owner { get; set; }
    }
}
