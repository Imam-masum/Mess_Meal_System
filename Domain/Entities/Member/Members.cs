using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Member
{
    public class Members:BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string MemberName { get; set; } = string.Empty;
        public string MemberContactNo { get; set; } = string.Empty;

        [Required(ErrorMessage ="Room can not be blank.")]
        public string RoomNo { get; set; } = string.Empty;
    }
}
