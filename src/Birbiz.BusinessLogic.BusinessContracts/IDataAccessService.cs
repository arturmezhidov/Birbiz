using System;
using Birbiz.DataAccess.DataContracts;

namespace Birbiz.BusinessLogic.BusinessContracts
{
    public interface IDataAccessService : IDisposable
    {
        IUnitOfWork DataContext { get; }
    }
}