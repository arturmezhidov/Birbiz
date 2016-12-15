using System;
using System.Linq;
using System.Linq.Expressions;
using Birbiz.Common.Entities;

namespace Birbiz.DataAccess.DataContracts
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity Create(TEntity entity);

        TEntity Update(TEntity entity);

        TEntity Delete(TEntity entity);

        TEntity Delete(object entityId);

        TEntity GetById(object entityId);

        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
    }
}