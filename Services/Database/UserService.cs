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


    // сделать еще один сервис по аналогии с UserService, назвать его WebSiteApiConsumeService 
    // взять у Гены код, который выполняет запросы к сайту по HTTP
    // встроить этот код в WebSiteApiConsumeService
    //в мобильном приложении сделать страницу, при заходе на которую будет два текстовых поля - дата и branchcode, кнопка для отправки запроса
    //по нажатию на кнопку - отправляем запрос к веб-методу сервиса сайта - как в примере в постмане, передаем туда дату и branchcode
    // веб апи (web api) в asp core, http client .net core (metanit , документация microsoft)
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
        /*************************************************************************************/
        /*
			+         0) исправить ошибки в проекте для того чтобы он запускался (ошибка запуска)
			+ (скрин) 1) дописать вызов из _userRepository метода DeleteUserAsync - таймкод примерно 1:06:00
			+		  2) почитать про async await
			+		  3) почитать про шаблоны в языке программирования C#
			4) почитать про внедрение зависимостей (Dependency Injection, DI) и использование в MAUI
			5) реализовать создание экземпляра класса UserService в интерфейсной части, т.е. внутри проекта Batischev_FitStat.Mobile
		*/
        /*************************************************************************************/
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
            throw new NotImplementedException();  // Почему "метод не реализован"
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
