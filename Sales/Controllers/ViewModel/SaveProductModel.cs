namespace Sales.Controllers.ViewModel
{
    public class SaveProductModel
    {
        public int? Id { get; set; }
        public int? BranchId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int CatType { get; set; }

    }
}
