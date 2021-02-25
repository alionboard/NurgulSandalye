using Ardalis.Specification;
using NurgulSandalye.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NurgulSandalye.DataAccess.Abstract
{
    public interface IAsyncRepository<T> where T:BaseEntity
    {
        Task<T> GetByIdAsync(int id);

        Task<List<T>> ListAllAsync();

        Task<List<T>> ListAsync(ISpecification<T> spec);

        Task<T> AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task<int> CountAsync(ISpecification<T> spec);

        Task<T> FirstAsync(ISpecification<T> spec);

        Task<T> FirstOrDefaultAsync(ISpecification<T> spec);

    }
}
