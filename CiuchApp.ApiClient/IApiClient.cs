using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using CiuchApp.Domain;

namespace CiuchApp.ApiClient
{
    public interface IApiClient
    {
        Task<CacheContext> GetCacheAsync();
        bool Add<T>(T item) where T : CiuchAppBaseModel;
        List<T> GetList<T>(int id = 0, string baseController = "");
        List<Piece> GetPieces();
        List<Piece> GetPiecesByBusinessTripId(int id);
        bool Update<T>(T item) where T : CiuchAppBaseModel;
        bool UploadImage(string localFilePath, string fileName);
    }
}