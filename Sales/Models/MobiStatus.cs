using System;
using System.Collections.Generic;

namespace Sales.Models
{
    public partial class MobiStatus
    {
        public MobiStatus()
        {
            MobiBranches = new HashSet<MobiBranch>();
            MobiCatagories = new HashSet<MobiCatagory>();
            MobiCountries = new HashSet<MobiCountry>();
            MobiDistricts = new HashSet<MobiDistrict>();
            MobiPurchaseProductStocks = new HashSet<MobiPurchaseProductStock>();
            MobiPurchases = new HashSet<MobiPurchase>();
            MobiStates = new HashSet<MobiState>();
            MobiSubCatagories = new HashSet<MobiSubCatagory>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<MobiBranch> MobiBranches { get; set; }
        public virtual ICollection<MobiCatagory> MobiCatagories { get; set; }
        public virtual ICollection<MobiCountry> MobiCountries { get; set; }
        public virtual ICollection<MobiDistrict> MobiDistricts { get; set; }
        public virtual ICollection<MobiPurchaseProductStock> MobiPurchaseProductStocks { get; set; }
        public virtual ICollection<MobiPurchase> MobiPurchases { get; set; }
        public virtual ICollection<MobiState> MobiStates { get; set; }
        public virtual ICollection<MobiSubCatagory> MobiSubCatagories { get; set; }
    }
}
