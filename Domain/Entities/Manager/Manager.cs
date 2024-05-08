using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Manager
{
    public class Manager:BaseEntity
    {
        [Required(ErrorMessage ="Manger should not be blank")]
        [StringLength(100)]

        public string ManagerName { get; set; } = string.Empty;
    }
}
