﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO.Menu
{
    public class MenuReadDto
    {
        #region Public Properties

        public long Id { get; set; }
        public long ParentID { get; set; }
        public string MenuName { get; set; } = string.Empty;
        public int MenuOrder { get; set; }
        public bool IsParent { get; set; }
        public bool IsTopLevel { get; set; }
        public string? Area { get; set; }
        public string? Action { get; set; }
        public string? Controller { get; set; }
        public string? IconClass { get; set; }
        public string? Module { get; set; }
        public string RoutePath { get; set; } = string.Empty;
        public List<MenuReadDto> childItems { get; set; }=new List<MenuReadDto>();
        #endregion
    }
}
