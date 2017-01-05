using Birbiz.Common.Entities;

namespace Birbiz.BusinessLogic.BusinessContracts
{
    public interface IEntityService<TEntity> : IDataAccessService where TEntity : BaseEntity
    {
        TEntity Create(TEntity entity);
    }
}