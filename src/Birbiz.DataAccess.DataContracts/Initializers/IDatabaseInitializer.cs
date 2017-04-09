using System.Collections.Generic;

namespace Birbiz.DataAccess.DataContracts.Initializers
{
    public interface IDatabaseInitializer
    {
        IEnumerable<IInitializerEntity> EntityCollections { get; }

        IInitializerEntityCollection<TEntity> GetEntityCollection<TEntity>();
    }
}