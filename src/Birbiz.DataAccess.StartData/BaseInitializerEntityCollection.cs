using System;
using System.Collections;
using System.Collections.Generic;
using Birbiz.DataAccess.DataContracts.Initializers;

namespace Birbiz.DataAccess.StartData
{
    public abstract class BaseInitializerEntityCollection<TEntity> : IInitializerEntityCollection<TEntity>
    {
        private IEnumerable<TEntity> entities;

        public Type EntityType
        {
            get
            {
                return typeof(TEntity);
            }
        }

        public IEnumerable<TEntity> Entities
        {
            get
            {
                if (entities == null)
                {
                    entities = GetEntities();
                }

                return entities;
            }
        }

        public IEnumerator<TEntity> GetEnumerator()
        {
            return Entities.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        protected abstract IEnumerable<TEntity> GetEntities();
    }
}