using System.Collections.Generic;
using System.IO;
using CiuchApp.Domain;

namespace CiuchApp.ApiClient
{
    public interface IApiClient
    {
        CacheContext GetCache();
        bool Add<T>(T item) where T : CiuchAppModelBase;
        List<T> GetList<T>(int id = 0, string baseController = "");
        List<Piece> GetPieces();
        List<Piece> GetPiecesByBusinessTripId(int id);
        bool Update<T>(T item) where T : CiuchAppModelBase;
        bool UploadImage(string localFilePath, string fileName);
    }
}