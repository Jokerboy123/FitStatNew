using Contracts.Base;
using Contracts.Models;
using Contracts.Models.WebAPI;
using Services.Database;
using Services.IWebAPIConsume;

namespace Services.WebAPIConsume {
    public class BranchWebAPIService : IBranchWebAPIService {
        public WebSiteApiConsumeService _webSiteApiConsumeService { get; }
        private SettingsInfo _settings;
        public BranchWebAPIService(SettingsInfo settings) {
            _webSiteApiConsumeService = new WebSiteApiConsumeService(settings);
            _settings = settings;
        }
        /// <summary>
        /// Метод получения переченя тренировок за день в филиале.
        /// </summary>
        public async Task<EntityResponseModel<List<UserCheckListRowForShowWebAPI>>> GetTrainingForBranchAndDay(DateTime Date, Guid BranchCode) {             
            var requestResult = await _webSiteApiConsumeService.ConsumeService<EntityResponseModel<List<UserCheckListRowForShowWebAPI>>> (
                _webSiteApiConsumeService.FormatRequestUrl(_settings.WebSiteBaseUrl, "GetTrainingForBranchAndDay"),
                HttpMethod.Post, new { Date = Date, BranchCode = BranchCode });
            return requestResult;
        }
        //из этого куска получить модель и ее отправить по кноке по параметрам Date, BranchCode

        //UserCheckListRowForShowWebAPI - всегда называть так.
        /// <summary>
        /// Метод получения списка польователей по дате и его коду.
        /// </summary>

        //public async Task<EntityResponseModel<List<UserCheckListRowForShowWebAPI>>> GetUserByDateAndCode(DateTime Date, Guid UserId) {
        //    var requestResult = await _webSiteApiConsumeService.ConsumeService<EntityResponseModel<List<UserCheckListRowForShowWebAPI>>> (
        //        _webSiteApiConsumeService.FormatRequestUrl(_settings.WebSiteBaseUrl, "GetUserByDateAndCode"),
        //        HttpMethod.Post, new { Date = Date, UserId = UserId });
        //    return requestResult;
        //}
    }
}
