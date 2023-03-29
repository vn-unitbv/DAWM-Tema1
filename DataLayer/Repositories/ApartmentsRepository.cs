using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;

namespace DataLayer.Repositories
{
    public class ApartmentsRepository
    {
        private readonly AppDbContext dbContext;

        public ApartmentsRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Apartment> GetAll()
        {
            return dbContext.Apartments;
        }

        public Apartment? GetById(int apartmentId)
        {
            var result = dbContext.Apartments.FirstOrDefault(e => e.Id == apartmentId);

            return result;
        }

        public bool DeleteById(int apartmentId)
        {
            int index = dbContext.Apartments.FindIndex(e => e.Id == apartmentId);

            if (index == -1)
                return false;

            dbContext.Apartments.RemoveAt(index);

            return true;
        }
    }
}
