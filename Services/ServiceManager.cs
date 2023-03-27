using Domain.IRepositories;
 using Services.Abstractions;
using Services.Abstractions.Database;
 using Services.Database;
 using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
	public sealed class ServiceManager : IServiceManager
	{
		private readonly Lazy<IUserService> _lazyUserService;
		 
        public ServiceManager(IRepositoryManager repositoryManager)
		{
			_lazyUserService = new Lazy<IUserService>(() => new UserService(repositoryManager,this));			
        }

        public IUserService _userService => _lazyUserService.Value;
		 

    }
}
