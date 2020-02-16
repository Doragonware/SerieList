using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IRepository
    {
        Task<T> Add<T>(T entity) where T : class;
        Task<T> GetById<T>(int id) where T : class;
        Task<IEnumerable<T>> GetAll<T>() where T : class;
        Task<T> FirstOrDefault<T>(Expression<Func<T, bool>> predicate) where T : class;
        Task<bool> Any<T>(Expression<Func<T, bool>> predicate) where T : class;
        void Update<T>(T entity) where T : class;
        void Remove<T>(T entity) where T : class;
        Task<bool> SaveChanges();
    }
}
