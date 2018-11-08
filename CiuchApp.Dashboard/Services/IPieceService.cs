using CiuchApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CiuchApp.Dashboard.Services
{
    public interface IPieceService
    {
        IList<Piece> GetPieces();
        bool AddPiece(Piece piece);
        bool UpdatePiece(Piece piece);
        bool DeletePiece(Piece piece);

    }
}
