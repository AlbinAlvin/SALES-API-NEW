using System;
using System.Collections.Generic;

namespace Sales.Models
{
    public partial class MobiBranch
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string? Address { get; set; }
        public int? ZipCode { get; set; }
        public string? District { get; set; }
        public string? Icon { get; set; }
        public string? Banner { get; set; }
        public int StatusId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual MobiStatus Status { get; set; } = null!;
    }
}
