using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Birbiz.Common.Entities;
using Birbiz.DataAccess.DataContracts;
using Birbiz.DataAccess.DataContracts.Initializers;

namespace Birbiz.DataAccess.SqlDataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext context;
        private readonly IDatabaseInitializer databaseInitializer;
        private readonly Dictionary<string, object> repositories;
        private bool disposed;

        public UnitOfWork(DataContext dataContext, IDatabaseInitializer databaseInitializer)
        {
            context = dataContext;
            this.databaseInitializer = databaseInitializer;
            repositories = new Dictionary<string, object>();
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : BaseEntity
        {
            string key = typeof(TEntity).Name;

            if (!repositories.ContainsKey(key))
            {
                IRepository<TEntity> newRepository = new Repository<TEntity>(context);
                repositories.Add(key, newRepository);
            }

            IRepository<TEntity> repository = (IRepository<TEntity>)repositories[key];
            return repository;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void EnsureCreated()
        {
            bool isCreated = context.Database.EnsureCreated();

            if (isCreated)
            {
                IInitializable initializable = context as IInitializable;

                initializable?.Init(databaseInitializer);
            }
        }

        public void Migrate()
        {
            context.Database.Migrate();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                disposed = true;
            }
        }
    }
}