using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Menu
{
    public class MenuPermission:BaseEntity
    {
        #region Public Properties

        public long UserId { get; set; }
        public long MenuId { get; set; }
        public bool Permission { get; set; }
        public bool ViewPermission { get; set; }
        public bool CreatePermission { get; set; }
        public bool EditPermission { get; set; }
        public bool DeletePermission { get; set; }

        #endregion Public Properties
    }
}
