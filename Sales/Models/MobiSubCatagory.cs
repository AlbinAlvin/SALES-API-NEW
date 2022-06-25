using System;
using System.Collections.Generic;

namespace Sales.Models
{
    public partial class MobiSubCatagory
    {
        public MobiSubCatagory()
        {
            MobiPurchaseProductStocks = new HashSet<MobiPurchaseProductStock>();
            MobiPurchases = new HashSet<MobiPurchase>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public int CatagoryId { get; set; }
        public int StatusId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual MobiCatagory Catagory { get; set; } = null!;
        public virtual MobiStatus Status { get; set; } = null!;
        public virtual ICollection<MobiPurchaseProductStock> MobiPurchaseProductStocks { get; set; }
        public virtual ICollection<MobiPurchase> MobiPurchases { get; set; }
    }
}
