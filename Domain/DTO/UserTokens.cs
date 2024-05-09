using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class UserTokens
    {
        #region
        public string   Token { get; set; }=string.Empty;
        public string UserName { get; set; } = string.Empty;
        public TimeSpan Validaty { get; set; }
        public string RefreshToken { get; set; } = string.Empty;
        public long Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public long MemberId { get; set; }
        public Guid  GuidId { get; set; }
        public DateTime ExpiredTime { get; set; }
        #endregion
    }
}
