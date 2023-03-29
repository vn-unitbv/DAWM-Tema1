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

        public ApartmentAddressDto Address { get; set; }

        public float TotalArea { get; set; }

        public float UsableArea { get; set; }

        public int NumberOfRooms { get; set; }

        // String for now so as not to complicate this
        // simple homework pointlessly
        public string Owner { get; set; }

        public ApartmentDto(Apartment apartment)
        {
            Id = apartment.Id;
            Address = new()
            {
                Id = apartment.Address.Id,
                City = apartment.Address.City,
                Street = apartment.Address.Street,
                Number = apartment.Address.Number,
                Section = apartment.Address.Section,
                BuildingNumber = apartment.Address.BuildingNumber,
                Floor = apartment.Address.Floor,
                ApartmentNumber = apartment.Address.ApartmentNumber
            };
            TotalArea = apartment.TotalArea;
            UsableArea = apartment.UsableArea;
            NumberOfRooms = apartment.NumberOfRooms;
            Owner = apartment.Owner;
        }
    }
}
