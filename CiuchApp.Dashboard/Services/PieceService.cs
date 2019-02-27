using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CiuchApp.DataAccess;
using CiuchApp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace CiuchApp.Dashboard.Services
{
    public class PieceService : BaseService<Piece>, ICrudService<Piece>
    {
        public PieceService(ApplicationDbContext context) : base(context) {}

        public IList<Piece> GetAll()
        {
            return GetPiecesAndIncludedValues().ToList();
        }

        public async Task<List<Piece>> GetAllAsync()
        {
            return await GetPiecesAndIncludedValues().ToListAsync();
        }

        public bool Add(Piece item)
        {
            _context.Pieces.Add(item);
            return _context.SaveChanges() > 0;
        }

        public bool Update(Piece item)
        {
            _context.Entry(item).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }

        public bool Delete(Piece item)
        {
            _context.Pieces.Remove(item);
            return _context.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            _context.Pieces.Remove(_context.Pieces.First(x=>x.Id==id));
            return _context.SaveChanges() > 0;
        }

        public Piece GetById(int id)
        {
            return GetPiecesAndIncludedValues().GetById(id);
        }

        public IIncludableQueryable<Piece, Size> GetPiecesAndIncludedValues()
        {
            return _context.Pieces
                           .Include(p => p.BusinessTrip).ThenInclude(b => b.City)
                           .Include(p => p.BusinessTrip).ThenInclude(b => b.Country)
                           .Include(p => p.BusinessTrip).ThenInclude(b => b.Currency)
                           .Include(p => p.BusinessTrip).ThenInclude(b => b.Season)
                           .Include(p => p.CodeCn)
                           .Include(p => p.Color)
                           .Include(p => p.ColorName)
                           .Include(p => p.Component)
                           .Include(p => p.CountryOfOrigin)
                           .Include(p => p.Group)
                           .Include(p => p.MainCategory)
                           .Include(p => p.Set)
                           .Include(p => p.Supplier)
                           .Include(p => p.TopCategory)
                           .Include(p => p.SizeAmountPairs).ThenInclude(q => q.Size);
        }
    }
}
