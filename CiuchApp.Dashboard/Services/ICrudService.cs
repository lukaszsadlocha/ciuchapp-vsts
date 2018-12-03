using CiuchApp.DataAccess;
using System.Collections.Generic;

namespace CiuchApp.Dashboard.Services
{
    public interface ICrudService<T>
    {
        IList<T> GetAll();
        bool Add(T item);
        bool Update(T item);
        bool Delete(T item);
        ApplicationDbContext GetContext();
    }
}
