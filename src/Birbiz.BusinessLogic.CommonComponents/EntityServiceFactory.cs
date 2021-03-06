﻿using Birbiz.BusinessLogic.BusinessContracts;
using Birbiz.Common.Entities;
using Birbiz.DataAccess.DataContracts;

namespace Birbiz.BusinessLogic.CommonComponents
{
    public class EntityServiceFactory : IEntityServiceFactory
    {
        private readonly IUnitOfWork _dataContext;
        private readonly IUserService _userService;

        public EntityServiceFactory(IUnitOfWork dataContext, IUserService userService)
        {
            _dataContext = dataContext;
            _userService = userService;
        }

        public IEntityService<TEntity> Create<TEntity>() where TEntity : BaseEntity
        {
            IRepository<TEntity> repository = _dataContext.GetRepository<TEntity>();
            IEntityService<TEntity> service = new EntityService<TEntity>(repository, _userService);
            return service;
        }
    }
}