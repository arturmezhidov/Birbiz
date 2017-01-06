using System;
using System.Linq;
using System.Linq.Expressions;
using Birbiz.BusinessLogic.BusinessContracts;
using Birbiz.Common.Entities;
using Birbiz.DataAccess.DataContracts;

namespace Birbiz.BusinessLogic.CommonComponents
{
    public class EntityService<TEntity> : IEntityService<TEntity> where TEntity : BaseEntity
    {
        protected IRepository<TEntity> Repository { get; private set; }
        protected IUserService UserService { get; private set; }

        public EntityService(IRepository<TEntity> repository, IUserService userService)
        {
            Repository = repository;
            UserService = userService;
        }

        public virtual TEntity Create(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            entity.CreatedBy = UserService.GetCurrentUserName();
            entity.UpdatedBy = UserService.GetCurrentUserName();
            entity.IsDeleted = false;
            entity.CreatedDate = DateTime.Now;
            entity.LastUpdatedDate = DateTime.Now;

            entity = Repository.Create(entity);

            return entity;
        }

        public virtual TEntity Update(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            entity.UpdatedBy = UserService.GetCurrentUserName();
            entity.LastUpdatedDate = DateTime.Now;

            entity = Repository.Update(entity);

            return entity;
        }

        public virtual TEntity Delete(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            entity.IsDeleted = true;

            entity = Update(entity);

            return entity;
        }

        public virtual TEntity Delete(object entityId)
        {
            if (entityId == null)
            {
                throw new ArgumentNullException(nameof(entityId));
            }

            TEntity entity = GetById(entityId);

            if (entity != null)
            {
                entity = Delete(entity);
            }

            return entity;
        }

        public virtual TEntity Recovery(object entityId)
        {
            if (entityId == null)
            {
                throw new ArgumentNullException(nameof(entityId));
            }

            TEntity entity = GetDeletedById(entityId);

            if (entity != null)
            {
                entity.IsDeleted = false;

                entity = Update(entity);
            }

            return entity;
        }

        public virtual TEntity GetById(object entityId)
        {
            if (entityId == null)
            {
                throw new ArgumentNullException(nameof(entityId));
            }

            TEntity entity = Repository.GetById(entityId);

            if (entity == null || entity.IsDeleted)
            {
                return null;
            }

            return entity;
        }

        public virtual TEntity GetDeletedById(object entityId)
        {
            if (entityId == null)
            {
                throw new ArgumentNullException(nameof(entityId));
            }

            TEntity entity = Repository.GetById(entityId);

            if (entity == null || !entity.IsDeleted)
            {
                return null;
            }

            return entity;
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            IQueryable<TEntity> result = Repository.Find(i => !i.IsDeleted);
            return result;
        }

        public virtual IQueryable<TEntity> GetDeletedAll()
        {
            IQueryable<TEntity> result = Repository.Find(i => i.IsDeleted);
            return result;
        }

        public virtual IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            var result = Repository.Find(predicate).Where(i => !i.IsDeleted);
            return result;
        }
    }
}