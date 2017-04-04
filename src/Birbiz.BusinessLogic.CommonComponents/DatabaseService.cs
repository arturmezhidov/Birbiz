using System;
using Birbiz.BusinessLogic.BusinessContracts;
using Birbiz.DataAccess.DataContracts;

namespace Birbiz.BusinessLogic.CommonComponents
{
    public class DatabaseService : IDatabaseService
    {
        private readonly IUnitOfWork dataContext;

        public DatabaseService(IUnitOfWork dataContext)
        {
            this.dataContext = dataContext;
        }

        public void CreateIfNotExist()
        {
            dataContext.EnsureCreated();
        }
    }
}