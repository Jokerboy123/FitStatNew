using Contracts.Base;

namespace Services.IWebAPIConsume {
    public interface IUserCheckListHeaderWebAPIService {
        /// <summary>
        /// Метод выставление отметки пользователя о присутсвии на занятии.
        /// </summary>
        Task<EntityResponseModel<BaseModel>> SetCheckByUserInSpace(Guid UserId, Guid MemberSpaceInSeasonId, Guid WorkTimeId);
        /// <summary>
        /// Метод подтверждения отметки пользователя на занятии.
        /// </summary>
        Task<EntityResponseModel<BaseModel>> ApproveUserCheckRowToday(Guid IdRow, Guid UserId);
    }
}