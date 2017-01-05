using Birbiz.Common.Entities;

namespace Birbiz.BusinessLogic.BusinessContracts
{
    public interface IEntityServiceFactory
    {
        IEntityService<TEntity> Create<TEntity>() where TEntity : BaseEntity;
    }
}