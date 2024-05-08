using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Base
{
    public class BaseEntity
    {
        #region
        public long Id { get; set; }
        public long MemberId { get; set; }
        public bool IsDelete { get; set; }
        [StringLength(100)]
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; }= DateTime.Now;
        [StringLength(100)]
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        #endregion
    }
}