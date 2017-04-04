using System;

namespace Birbiz.BusinessLogic.CommonComponents
{
    public abstract class Disposable
    {
        private bool _disposed;

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
                    OnDisposing();
                }
                _disposed = true;
            }
        }

        protected virtual void OnDisposing()
        {
            
        }
    }
}