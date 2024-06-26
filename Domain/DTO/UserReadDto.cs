﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class UserReadDto
    {
        public long Id { get; set; }
        public string UserName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
        public string Mobile { get; set; }=string.Empty;
    }
}
