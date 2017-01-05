using Birbiz.BusinessLogic.BusinessContracts;
using Birbiz.Common.Entities;
using Birbiz.DataAccess.DataContracts;

namespace Birbiz.BusinessLogic.CommonComponents
{
    public class EntityServiceFactory : IEntityServiceFactory
    {
        private readonly IUnitOfWork dataContext;

        public EntityServiceFactory(IUnitOfWork dataContext)
        {
            this.dataContext = dataContext;
        }

        public IEntityService<TEntity> Create<TEntity>() where TEntity : BaseEntity
        {
            IEntityService<TEntity> service = new EntityService<TEntity>(dataContext);
            return service;
        }
    }
}