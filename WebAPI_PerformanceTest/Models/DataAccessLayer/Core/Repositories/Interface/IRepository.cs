﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using WebAPI_PerformanceTest.Models.DataAccessLayer.Entities.GeneralData;

namespace WebAPI_PerformanceTest.Models.DataAccessLayer.Core.Repositories.Interface
{
    public interface IRepository<TEntity> where TEntity : IPersistenceEntities
    {
        TEntity GetById(string id);
        TEntity AddOrEdit(TEntity entity);
        bool Remove(string id);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> func);
        IEnumerable<TEntity> Include(params Expression<Func<TEntity, object>>[] includes);

    }
}