using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Utils
{
    public class JwtSetings
    {
        #region Public Properties

        public bool ValidateIssuerSigningKey { get; set; }

        public string IssuerSigningKey { get; set; } = string.Empty;

        public bool ValidateIssuer { get; set; } = true;

        public string ValidIssuer { get; set; } = string.Empty;

        public bool ValidateAudience { get; set; } = true;

        public string ValidAudience { get; set; } = string.Empty;

        public bool RequireExpirationTime { get; set; }

        public bool ValidateLifetime { get; set; } = true;

        #endregion Public Properties
    }
}
