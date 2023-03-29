using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Dtos;
using DataLayer.Entities;
using DataLayer.Repositories;

namespace Core.Services
{
    public class ApartmentService
    {
        private ApartmentsRepository apartmentsRepository { get; set; }

        public ApartmentService(ApartmentsRepository apartmentsRepository)
        {
            this.apartmentsRepository = apartmentsRepository;
        }

        public List<ApartmentBriefDto> GetAll()
        {
            var results = apartmentsRepository.GetAll()
                .Select(e => new ApartmentBriefDto(e)).ToList();
            return results;
        }

        public ApartmentDto? GetById(int apartmentId)
        {
            Apartment? apartment = apartmentsRepository.GetById(apartmentId);
            if (apartment == null)
                return null;
            ApartmentDto result = new(apartment);
            return result;
        }

        public bool EditArea(ApartmentUpdateAreaDto? payload)
        {
            if (payload == null)
                return false;

            Apartment? apartment = apartmentsRepository.GetById(payload.ApartmentId);

            if (apartment == null) return false;

            apartment.TotalArea = payload.TotalArea;
            apartment.UsableArea = payload.UsableArea;

            return true;
        }

        public bool DeleteById(int apartmentId)
        {
            return apartmentsRepository.DeleteById(apartmentId);
        }
    }
}
