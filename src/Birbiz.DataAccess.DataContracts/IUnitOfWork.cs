using System;
using Birbiz.Common.Entities;

namespace Birbiz.DataAccess.DataContracts
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity;

        void Save();

        void EnsureCreated();

        void Migrate();
    }
}