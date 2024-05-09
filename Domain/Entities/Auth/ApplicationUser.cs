using Domain.Entities.Base;
using Domain.Entities.Member;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Auth
{
    public class ApplicationUser:BaseEntity
    {
        [Required(ErrorMessage = "User Can not be empty")]
        [StringLength(50)]
        public string UserName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Password can not empty")]
        [StringLength(50), MinLength(6, ErrorMessage = "Password must be 6 charcecter")]
        public string Password { get; set; } = string.Empty;

        [StringLength(50)]
        public string BaseKey { get; set; } = string.Empty;

        public bool IsEmailVerified { get; set; }

        public bool IsAuthorized { get; set; }
        public int OTP { get; set; }

        [StringLength(50)]
        public string Email { get; set; } = string.Empty;
        public string Mobile { get; set; } = string.Empty;

        public string ActivationCode { get; set; } = string.Empty;
        [StringLength(50)]
        [Required(ErrorMessage = "First Name mandatory")]
        public string FirstName { get; set; } = string.Empty;
        [StringLength(50)]
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public Members Members { get; set; } = null!;
    }
}
