using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Menu
{
    public class MenuPermissionDto
    {
        #region Public Properties

        public long Id { get; set; }

        public long UserId { get; set; }
        public long MenuId { get; set; }
        public string MenuName { get; set; } = string.Empty;
        public string ParentMenu { get; set; } = string.Empty;
        public long ParentID { get; set; }
        public bool IsParent { get; set; }

        public bool Permission { get; set; }
        public bool ViewPermission { get; set; }
        public bool CreatePermission { get; set; }
        public bool EditPermission { get; set; }
        public bool DeletePermission { get; set; }

        #endregion Public Properties
    }
}
