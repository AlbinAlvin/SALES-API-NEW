using System;
using System.Collections.Generic;

namespace Sales.Models
{
    public partial class MobiDistrict
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public int State { get; set; }
        public int StatusId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual MobiState Status { get; set; } = null!;
        public virtual MobiStatus StatusNavigation { get; set; } = null!;
    }
}
