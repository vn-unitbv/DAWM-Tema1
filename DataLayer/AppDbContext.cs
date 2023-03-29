using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class AppDbContext : DbContext
    {
        AppDbContext()
        {

        }

        public List<Apartment> Apartments { get; set; }
    }
}
