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
        public required int Id { get; set; }

        public required int ApartmentId { get; set; }

        public required Apartment Apartment { get; set; }

        public required string City { get; set; }

        public required string Street { get; set; }

        public required string Number { get; set; }

        public required string BuildingNumber { get; set; }

        public required string Section { get; set; }

        public required string Floor { get; set; }

        public required string ApartmentNumber { get; set; }
    }
}
