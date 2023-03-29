using DataLayer.Entities;

namespace DataLayer
{
    public class AppDbContext
    {
        public AppDbContext()
        {
            ApartmentAddress address1 = new()
            {
                Id = 1,
                ApartmentId = 0,
                Apartment = null,
                City = "Brasov",
                Street = "Iuliu Maniu",
                Number = "5",
                Section = "A",
                BuildingNumber = "1",
                ApartmentNumber = "12",
                Floor = "2"
            };
            Apartment apartment1 = new()
            {
                Id = 1,
                Address = address1,
                AddressId = address1.Id,
                TotalArea = 74.3f,
                UsableArea = 56f,
                NumberOfRooms = 3,
                Owner = "John Smith"
            };
            address1.ApartmentId = apartment1.Id;
            address1.Apartment = apartment1;

            ApartmentAddress address2 = new()
            {
                Id = 2,
                ApartmentId = 0,
                Apartment = null,
                City = "Brasov",
                Street = "Iuliu Maniu",
                Number = "7",
                Section = "B",
                BuildingNumber = "2",
                ApartmentNumber = "25",
                Floor = "4"
            };
            Apartment apartment2 = new()
            {
                Id = 2,
                Address = address2,
                AddressId = address2.Id,
                TotalArea = 60f,
                UsableArea = 47.5f,
                NumberOfRooms = 2,
                Owner = "Forsen"
            };
            address2.ApartmentId = apartment2.Id;
            address2.Apartment = apartment2;

            Apartments = new() { apartment1, apartment2 };
            ApartmentAddresses = new() { address1, address2 };
        }

        public List<Apartment> Apartments { get; set; }

        public List<ApartmentAddress> ApartmentAddresses { get; set; }
    }
}
