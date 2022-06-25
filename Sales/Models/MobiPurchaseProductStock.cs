using System;
using System.Collections.Generic;

namespace Sales.Models
{
    public partial class MobiPurchaseProductStock
    {
        public int Id { get; set; }
        public int PurchaseId { get; set; }
        public int ProductId { get; set; }
        public int ModelId { get; set; }
        public int Quantity { get; set; }
        public string Imeinumber { get; set; } = null!;
        public int Gst { get; set; }
        public int Sgst { get; set; }
        public int PurchaseAmount { get; set; }
        public int? Discount { get; set; }
        public int SalesAmount { get; set; }
        public int StatusId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual MobiSubCatagory Model { get; set; } = null!;
        public virtual MobiCatagory Product { get; set; } = null!;
        public virtual MobiPurchase Purchase { get; set; } = null!;
        public virtual MobiStatus Status { get; set; } = null!;
    }
}
