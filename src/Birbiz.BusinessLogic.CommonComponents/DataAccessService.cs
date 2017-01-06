using System;
using Birbiz.BusinessLogic.BusinessContracts;
using Birbiz.DataAccess.DataContracts;

namespace Birbiz.BusinessLogic.CommonComponents
{
    public class DataAccessService : IDataAccessService
    {
        private readonly IUnitOfWork _dataContext;
        private bool _disposed;

        public IUnitOfWork DataContext
        {
            get { return _dataContext; }
        }

        public DataAccessService(IUnitOfWork dataContext)
        {
            _dataContext = dataContext;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dataContext.Dispose();
                }
                _disposed = true;
            }
        }
    }
}