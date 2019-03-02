using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CiuchApp.DataAccess;
using CiuchApp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace CiuchApp.Dashboard.Services
{
    public class BusinessTripService : BaseService<BusinessTrip>, ICrudService<BusinessTrip>
    {
        public BusinessTripService(ApplicationDbContext context): base(context){}

        public IList<BusinessTrip> GetAll()
        {
            return GetBusinessTripsAndIncludedValues().ToList();
        }

        public async Task<List<BusinessTrip>> GetAllAsync()
        {
            return await GetBusinessTripsAndIncludedValues().ToListAsync();
        }

        public bool Add(BusinessTrip item)
        {
            _context.BusinessTrips.Add(item);
            return _context.SaveChanges() > 0;
        }

        public bool Update(BusinessTrip item)
        {
            _context.Entry(item).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }

        public bool Delete(BusinessTrip item)
        {
            _context.BusinessTrips.Remove(item);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            _context.BusinessTrips.Remove(_context.BusinessTrips.First(x => x.Id == id));
            return _context.SaveChanges() > 0;
        }

        public BusinessTrip GetById(int id)
        {
            return GetBusinessTripsAndIncludedValues().GetById(id);
        }


        private IIncludableQueryable<BusinessTrip, Season> GetBusinessTripsAndIncludedValues()
        {
            return _context.BusinessTrips
                            .Include(b => b.City)
                            .Include(b => b.Country)
                            .Include(b => b.Currency)
                            .Include(b => b.Season);
        }
    }
}
