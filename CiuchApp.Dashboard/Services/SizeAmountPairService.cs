using System.Collections.Generic;
using System.Linq;
using CiuchApp.DataAccess;
using CiuchApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace CiuchApp.Dashboard.Services
{
    public class SizeAmountPairService : ICrudService<SizeAmountPair>

    {
        private readonly ApplicationDbContext _context;

        public SizeAmountPairService(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Add(SizeAmountPair item)
        {
            _context.SizeAmountPairs.Add(item);
            return _context.SaveChanges() > 0;
        }

        public bool Delete(SizeAmountPair item)
        {
            _context.SizeAmountPairs.Remove(item);
            return _context.SaveChanges() > 0;
        }

        public IList<SizeAmountPair> GetAll()
        {
            return _context.SizeAmountPairs
                    .Include(p => p.Size)
                    .ToList();
        }

        public bool Update(SizeAmountPair item)
        {
            _context.Entry(item).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }
        public ApplicationDbContext GetContext()
        {
            return _context;
        }
    }
}
