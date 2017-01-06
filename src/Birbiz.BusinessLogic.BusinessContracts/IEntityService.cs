using System;
using System.Linq;
using System.Linq.Expressions;
using Birbiz.Common.Entities;

namespace Birbiz.BusinessLogic.BusinessContracts
{
    public interface IEntityService<TEntity> where TEntity : BaseEntity
    {
        TEntity Create(TEntity entity);

        TEntity Update(TEntity entity);

        TEntity Delete(TEntity entity);

        TEntity Delete(object entityId);

        TEntity Recovery(object entityId);

        TEntity GetById(object entityId);

        TEntity GetDeletedById(object entityId);

        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> GetDeletedAll();

        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
    }
}