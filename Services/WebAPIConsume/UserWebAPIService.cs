using Contracts.Base;
using Contracts.Models;
using Contracts.Models.Entities;
using Services.Database;
using Services.IWebAPIConsume;

namespace Services.WebAPIConsume {
    public class UserWebAPIService : IUserWebAPIService {
        public WebSiteApiConsumeService _webSiteApiConsumeService { get; }
        private SettingsInfo _settings;
        public UserWebAPIService(SettingsInfo settings) {
            _webSiteApiConsumeService = new WebSiteApiConsumeService(settings);
            _settings = settings;
        }
        /// <summary>
        /// Метод авторизации пользователя.
        /// </summary>
        public async Task<EntityResponseModel<UserDto>> LoginUser(string UserName, string Password) {
            var requestResult = await _webSiteApiConsumeService.ConsumeService<EntityResponseModel<UserDto>>(
                _webSiteApiConsumeService.FormatRequestUrl(_settings.WebSiteBaseUrl, "loginuser"),
                HttpMethod.Post, new { UserName = UserName, Password = Password });
            return requestResult;
        }
    }
}