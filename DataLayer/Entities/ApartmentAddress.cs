using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    /// <summary>
    /// Entity representing the address of an apartment;
    /// as such, it also contains information about its
    /// location within the apartment building it resides in.
    /// All properties are strings to account for unusual
    /// cases of non-numeric address parts.
    /// </summary>
    public class ApartmentAddress
    {
        public int Id { get; set; }

        public int ApartmentId { get; set; }

        public Apartment Apartment { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string Number { get; set; }

        public string BuildingNumber { get; set; }

        public string Section { get; set; }

        public string Floor { get; set; }

        public string ApartmentNumber { get; set; }
    }
}
