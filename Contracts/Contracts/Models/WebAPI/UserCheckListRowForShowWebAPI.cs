using System.Text.Json.Serialization;
using Contracts.Base;
using Contracts.Models.Entities;

namespace Contracts.Models.WebAPI {
    public class UserCheckListRowForShowWebAPI : BaseEntityModel {
        public DateTime DateCheck { get; set; }
        public DateTime? DateApproved { get; set; }
        [JsonIgnore]
        public UserDtoBaseData User { get; set; }
        public string UserInfo { get; set; }
    }
}
