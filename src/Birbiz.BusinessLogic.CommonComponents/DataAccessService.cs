using System;
using Birbiz.BusinessLogic.BusinessContracts;
using Birbiz.DataAccess.DataContracts;

namespace Birbiz.BusinessLogic.CommonComponents
{
    public class DataAccessService : IDataAccessService
    {
        private readonly IUnitOfWork dataContext;
        private bool disposed;

        public IUnitOfWork DataContext
        {
            get { return dataContext; }
        }

        public DataAccessService(IUnitOfWork dataContext)
        {
            this.dataContext = dataContext;
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
                    dataContext.Dispose();
                }
                disposed = true;
            }
        }
    }
}