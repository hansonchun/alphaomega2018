using AlphaOmega.ApplicationCore.Entities;
using AlphaOmega.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlphaOmega.Infrastructure.Data
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DbContext _dbContext;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public T Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();

            return entity;
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public T GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public IEnumerable<T> ListAll()
        {
            return _dbContext.Set<T>().AsEnumerable();
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
