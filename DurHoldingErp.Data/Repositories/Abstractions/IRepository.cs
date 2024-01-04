using DurHoldingErp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DurHoldingErp.Data.Repositories.Abstractions
{
    public interface IRepository<T> : IEntityBase where T : class, new()
    {

        Task AddAsyn(T add);

        Task<List<T>> GetAllAsyn(Expression<Func<T,bool>> predicate =null ,params Expression<Func<T, object>>[] includePropertes);

        Task<T> GetAsyn(Expression<Func<T, bool>> predicate , params Expression<Func<T, object>>[] includePropertes);

        Task<T> GetByGuidAsyn(Guid id);

        Task<T> UpdateAsyn(T Entity);

        Task DeleteAsyn(T Entity);


    }
}
