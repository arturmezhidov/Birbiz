using System;
using System.Collections.Generic;
using System.Linq;
using Birbiz.DataAccess.DataContracts.Initializers;

namespace Birbiz.DataAccess.StartData
{
    public class DatabaseInitializer : IDatabaseInitializer
    {
        private IEnumerable<IInitializerEntity> entityCollections;

        public IEnumerable<IInitializerEntity> EntityCollections
        {
            get
            {
                if (entityCollections == null)
                {
                    entityCollections = GetEntityCollections();
                }

                return entityCollections;
            }
        }

        public IInitializerEntityCollection<TEntity> GetEntityCollection<TEntity>()
        {
            Type type = typeof(TEntity);

            IInitializerEntityCollection<TEntity> initializer = EntityCollections.FirstOrDefault(i => i.EntityType == type) as IInitializerEntityCollection<TEntity>;

            return initializer;
        }

        protected IEnumerable<IInitializerEntity> GetEntityCollections()
        {
            return new List<IInitializerEntity>
            {
                new UserRoleInitializer()
            };
        }
    }
}