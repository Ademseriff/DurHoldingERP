using DurHoldingErp.Core.Entities;
using DurHoldingErp.Data.Context;
using DurHoldingErp.Data.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DurHoldingErp.Data.Repositories.Concretes
{
    public class Repository<T> :IRepository<T>,IEntityBase where T : class,new()
    {
        private readonly AppDbContext _dbContext;

        public Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        private DbSet<T> Table { get => _dbContext.Set<T>(); }


       public async Task AddAsyn(T add)
        {
            await Table.AddAsync(add);
        }

        public async Task DeleteAsyn(T Entity)
        {
            await Task.Run(() => Table.Remove(Entity));
        }

        public async Task<List<T>> GetAllAsyn(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includePropertes)
        {
            IQueryable<T> query = Table;

            if(predicate != null)
            {
                query = query.Where(predicate);
            }
            if(includePropertes.Any())
            {
                foreach(var item in includePropertes) 
                    query = query.Include(item);
            }
            return await query.ToListAsync();

        }

        public async Task<T> GetAsyn(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includePropertes)
        {
            IQueryable<T> query = Table;
            query = query.Where(predicate);

            if (includePropertes.Any())
            {
                foreach (var item in includePropertes)
                    query = query.Include(item);
            }
            return await query.SingleAsync();
        }

        public async Task<T> GetByGuidAsyn(Guid id)
        {
            return await Table.FindAsync(id);
        }

        public async Task<T> UpdateAsyn(T Entity)
        {
            await Task.Run(()=> Table.Update(Entity));
            return Entity;

        }
    }
}
