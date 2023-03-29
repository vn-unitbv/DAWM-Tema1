using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class ApartmentDto
    {
        public int Id { get; set; }

        public ApartmentAddress Address { get; set; }

        public float TotalArea { get; set; }

        public float UsableArea { get; set; }

        public int NumberOfRooms { get; set; }

        // String for now so as not to complicate this
        // simple homework pointlessly
        public string Owner { get; set; }

        public ApartmentDto(Apartment apartment)
        {
            Id = apartment.Id;
            Address = apartment.Address;
            TotalArea = apartment.TotalArea;
            UsableArea = apartment.UsableArea;
            NumberOfRooms = apartment.NumberOfRooms;
            Owner = apartment.Owner;
        }
    }
}
