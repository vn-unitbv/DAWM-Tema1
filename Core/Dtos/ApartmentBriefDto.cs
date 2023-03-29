using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class ApartmentBriefDto
    {
        public required int Id { get; set; }

        public required string OwnerName { get; set; }

        public required string City { get; set; }

        public required string Street { get; set; }

        public ApartmentBriefDto(Apartment apartment)
        {
            Id = apartment.Id;
            OwnerName = apartment.Owner;
            City = apartment.Address.City;
            Street = apartment.Address.Street;
        }
    }
}
