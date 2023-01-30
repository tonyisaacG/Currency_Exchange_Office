﻿
using Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected DbContextRepository RepositoryContext;
        public BaseRepository(DbContextRepository repositoryContext) =>
            RepositoryContext = repositoryContext;
        public void Create(T entity) =>
            RepositoryContext.Set<T>().Add(entity);

        public void Delete(T entity) =>
            RepositoryContext.Set<T>().Remove(entity);
        public void Update(T entity) =>
            RepositoryContext.Set<T>().Update(entity);
        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ?
                RepositoryContext.Set<T>().AsNoTracking() :
                RepositoryContext.Set<T>();


        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
            !trackChanges ?
                RepositoryContext.Set<T>().Where(expression).AsNoTracking() :
                RepositoryContext.Set<T>().Where(expression);

    }
}
