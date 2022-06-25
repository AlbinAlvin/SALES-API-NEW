using System;
using System.Collections.Generic;

namespace Sales.Models
{
    public partial class MobiCountry
    {
        public MobiCountry()
        {
            MobiStates = new HashSet<MobiState>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public int StatusId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual MobiStatus Status { get; set; } = null!;
        public virtual ICollection<MobiState> MobiStates { get; set; }
    }
}
