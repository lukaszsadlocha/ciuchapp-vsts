using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CiuchApp.DataAccess;
using CiuchApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace CiuchApp.Dashboard.Services
{
    public class PieceService : IPieceService
    {
        private readonly ApplicationDbContext _context;

        public PieceService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Piece> GetPieces()
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
                .Include(p => p.SizeAmountPairs).ThenInclude(q => q.Size).ToList();
        }

        public bool AddPiece(Piece piece)
        {
            //Model is valid at this point
            _context.Pieces.Add(piece);
            return _context.SaveChanges() > 0;
        }

        public bool UpdatePiece(Piece piece)
        {
            _context.Entry(piece).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }

        public bool DeletePiece(Piece piece)
        {
            _context.Pieces.Remove(piece);
            return _context.SaveChanges() > 0;
        }
    }
}
