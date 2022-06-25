using System;
using System.Collections.Generic;

namespace Sales.Models
{
    public partial class MobiCatagory
    {
        public MobiCatagory()
        {
            MobiPurchaseProductStocks = new HashSet<MobiPurchaseProductStock>();
            MobiPurchases = new HashSet<MobiPurchase>();
            MobiSubCatagories = new HashSet<MobiSubCatagory>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public int StatusId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public int? BranchId { get; set; }
        public int? CatType { get; set; }
        public virtual MobiStatus Status { get; set; } = null!;
        public virtual ICollection<MobiPurchaseProductStock> MobiPurchaseProductStocks { get; set; }
        public virtual ICollection<MobiPurchase> MobiPurchases { get; set; }
        public virtual ICollection<MobiSubCatagory> MobiSubCatagories { get; set; }
    }
}
