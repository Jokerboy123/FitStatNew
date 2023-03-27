using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Contracts.Models.Entities
{
    public class LoggedUserWebDto:LoggedUserDto
    {
        [JsonIgnore]
        public List<Claim> UserRights { get; set; } = new List<Claim>();
        public bool HasRight(DefaultConstants.RoleRights currentRight)
        {
            return UserRights.Where(m => (m.Value ?? "") == currentRight.ToString()).Count() != 0;
        }
    }
}
