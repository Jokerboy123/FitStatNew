using Contracts.Base;
using Contracts.Models.WebAPI;

namespace Services.IWebAPIConsume {
    public interface IBranchWebAPIService {
        /// <summary>
        /// Метод получения переченя тренировок за день в филиале.
        /// </summary>
        Task<EntityResponseModel<List<UserCheckListRowForShowWebAPI>>> GetTrainingForBranchAndDay(DateTime Date, Guid BranchCode);
        /// <summary>
        /// Метод получения списка польователей по дате и его коду.
        /// </summary>
        
        //Task<EntityResponseModel<List<UserCheckListRowForShowWebAPI>>> GetUserByDateAndCode(DateTime Date, Guid UserId);
    }
}
