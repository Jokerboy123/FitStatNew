using Contracts.Base;
using Contracts.Models.Entities;

namespace Services.IWebAPIConsume {
    public interface IUserWebAPIService {
        /// <summary>
        /// Метод авторизации пользователя.
        /// </summary>
        Task<EntityResponseModel<UserDto>> LoginUser(string UserName, string Password);
    }
}