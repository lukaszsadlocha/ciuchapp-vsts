using CiuchApp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CiuchApp.DataAccess
{
    public static class DbSetExtensions
    {
        public static T GetById<T>(this DbSet<T> dbSet, int id) where T : CiuchAppBaseModel
        {
            return dbSet.First(x => x.Id == id);
        }

        public static T GetById<T>(this IQueryable<T> iq, int id) where T: CiuchAppBaseModel
        {
            return iq.First(x => x.Id == id);
        }

        public static C GetById<C, T>(this IIncludableQueryable<C, T> iq, int id) where C : CiuchAppBaseModel where T : CiuchAppBaseModel
        {
            return iq.First(x => x.Id == id);
        }
    }
}
