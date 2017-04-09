using System.Collections.Generic;

namespace Birbiz.DataAccess.DataContracts.Initializers
{
    public interface IInitializerEntityCollection<out TEntity> : IInitializerEntity, IEnumerable<TEntity>
    {
        IEnumerable<TEntity> Entities { get; }
    }
}