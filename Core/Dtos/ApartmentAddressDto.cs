using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class ApartmentAddressDto
    {
        public int Id { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string Number { get; set; }

        public string BuildingNumber { get; set; }

        public string Section { get; set; }

        public string Floor { get; set; }

        public string ApartmentNumber { get; set; }
    }
}
