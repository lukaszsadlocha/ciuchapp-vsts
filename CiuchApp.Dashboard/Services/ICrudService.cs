using CiuchApp.DataAccess;
using CiuchApp.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CiuchApp.Dashboard.Services
{
    public interface ICrudService<T> where T : CiuchAppBaseModel
    {
        IList<T> GetAll();
        T GetById(int id);
        bool Add(T item);
        bool Update(T item);
        bool Delete(T item);
        bool Delete(int id);
        ApplicationDbContext GetContext();
        DbSet<T> GetSet();
    }
}
