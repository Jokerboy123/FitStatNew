using Contracts.Base;
using Contracts.Models;
using Services.Database;
using Services.IWebAPIConsume;

namespace Services.WebAPIConsume {
    public class UserCheckListHeaderWebAPIService : IUserCheckListHeaderWebAPIService {
        public WebSiteApiConsumeService _webSiteApiConsumeService { get; }
        private SettingsInfo _settings;
        public UserCheckListHeaderWebAPIService(SettingsInfo settings) {
            _webSiteApiConsumeService = new WebSiteApiConsumeService(settings);
            _settings = settings;
        }
        /// <summary>
        /// Метод выставление отметки пользователя о присутсвии на занятии.
        /// </summary>
        public async Task<EntityResponseModel<BaseModel>> SetCheckByUserInSpace(Guid UserId, Guid MemberSpaceInSeasonId, Guid WorkTimeId) {
            var requestResult = await _webSiteApiConsumeService.ConsumeService<EntityResponseModel<BaseModel>>(
                _webSiteApiConsumeService.FormatRequestUrl(_settings.WebSiteBaseUrl, "setcheckbyuserinspace"),
                HttpMethod.Post, new { UserId = UserId, MemberSpaceInSeasonId = MemberSpaceInSeasonId, WorkTimeId = WorkTimeId });
            return requestResult;
        }
        /// <summary>
        /// Метод подтверждения отметки пользователя на занятии.
        /// </summary>
        public async Task<EntityResponseModel<BaseModel>> ApproveUserCheckRowToday(Guid IdRow, Guid UserId) {
            var requestResult = await _webSiteApiConsumeService.ConsumeService<EntityResponseModel<BaseModel>>(
                _webSiteApiConsumeService.FormatRequestUrl(_settings.WebSiteBaseUrl, "approveusercheckrowtoday"),
                HttpMethod.Post, new { IdRow = IdRow, UserId = UserId });
            return requestResult;
        }
    }
}