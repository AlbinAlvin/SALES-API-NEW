using System;
using System.Collections.Generic;

namespace Sales.Models
{
    public partial class MobiState
    {
        public MobiState()
        {
            MobiDistricts = new HashSet<MobiDistrict>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public int Countryid { get; set; }
        public int StatusId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual MobiCountry Status { get; set; } = null!;
        public virtual MobiStatus StatusNavigation { get; set; } = null!;
        public virtual ICollection<MobiDistrict> MobiDistricts { get; set; }
    }
}
