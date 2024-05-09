using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTO
{
    public class MemberDto
    {
        public long MemberId { get; set; }
        public string MemberName { get; set; } = string.Empty;
        public string MemberAddress { get; set; } = string.Empty;
        public string MemberContactNo { get; set; } = string.Empty;
        public string RoomNo { get; set; } = string.Empty;
    }
}
