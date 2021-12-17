using ChiuchApp.WebApi.Core3.DbContexts;
using ChiuchApp.WebApi.Core3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiuchApp.WebApi.Core3.Services
{
    public class PieceRepository : IPieceRepository, IDisposable
    {
        private readonly PieceDbContext _context;

        public PieceRepository(PieceDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));

        }

        public void AddPiece(Guid categoryId, Piece piece)
        {
            if(categoryId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(categoryId));
            }

            if(piece == null)
            {
                throw new ArgumentNullException(nameof(piece));
            }
            piece.CategoryId = categoryId;
            _context.Pieces.Add(piece);
            
        }



        public void Dispose()
        {
            throw new NotImplementedException();
        }

        
    }
}
