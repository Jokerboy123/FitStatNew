using Domain.Entities;
using Domain.IRepositories;
using Contracts;
using Contracts.Base;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Contracts.Models.Entities;
using Services.Abstractions.Database;
using Common;
using System.Security.Cryptography;
using System.Security.Claims;
using static Common.DefaultConstants;
using Contracts.Models.Tables;
using Contracts.Models.Controls;
using System.Diagnostics.Contracts;

namespace Services.Database
{

    public class UserService : IUserService
    {
		private readonly IRepositoryManager _repositoryManager;
		private readonly IServiceManager _serviceManager;

		public UserService(IRepositoryManager repositoryManager,
			IServiceManager serviceManager)
		{
			_repositoryManager = repositoryManager ?? throw new ArgumentNullException(nameof(repositoryManager));
			_serviceManager = serviceManager ?? throw new ArgumentNullException(nameof(serviceManager));
		}

        public async Task<bool> DeleteUserAsync(UserDto User) 
		{
            try
            {
                User Entity = ObjectMapper.Mapper.Map<User>(User);
                await _repositoryManager._userRepository.DeleteUserAsync(Entity);
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
        }
      
        /*************************************************************************************/
        public async Task<bool> SaveUser(UserDto User)
        {
            try
            {
                User Entity = ObjectMapper.Mapper.Map<User>(User);
                await _repositoryManager._userRepository.SaveUserAsync(Entity);
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
        }


        public Task<UserDto> SaveUser()
        {
            throw new NotImplementedException(); 
        }
        /*************************************************************************************/

        /// <summary>
        /// Получить текущего пользователя
        /// </summary>
        /// <returns></returns>
        public async Task<UserDto> GetCurrentUser()
		{
			try
			{
				var Entity = await _repositoryManager._userRepository.GetUserAsync();
				if (Entity == null)
				{
					return null;
				}
                UserDto MappedModel = ObjectMapper.Mapper.Map<UserDto>(Entity);
				return MappedModel;
            }
			catch(Exception exp)
			{
				return null;
			}
		}

		
	}
}
