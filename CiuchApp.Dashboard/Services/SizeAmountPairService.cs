using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CiuchApp.DataAccess;
using CiuchApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace CiuchApp.Dashboard.Services
{
    public class SizeAmountPairService : BaseService<SizeAmountPair>, ICrudService<SizeAmountPair>
    {
        public SizeAmountPairService(ApplicationDbContext context) : base(context)
        {
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
        public async Task<List<SizeAmountPair>> GetAllAsync()
        {
            return await _context.SizeAmountPairs.Include(p => p.Size).ToListAsync();
        }

        public bool Update(SizeAmountPair item)
        {
            _context.Entry(item).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }

        public SizeAmountPair GetById(int id)
        {
            return _context.SizeAmountPairs.First(x => x.Id == id);
        }

        public bool Delete(int id)
        {
            _context.SizeAmountPairs.Remove(_context.SizeAmountPairs.First(x => x.Id == id));
            return _context.SaveChanges() > 0;
        }
    }
}
