using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sales.Controllers.ViewModel;
using Sales.Models;

namespace Sales.Controllers
{
    [Route("api/product/")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly Mobi_SalesContext _mobi_SalesContext;

        public ProductController(ILogger<ProductController> logger, Mobi_SalesContext mobi_SalesContext)
        {
            _logger = logger;
            _mobi_SalesContext = mobi_SalesContext;
        }
        [HttpGet]
        [Route("getProduct")]
        public IList<MobiCatagory> GetProduct()
        {
            var data = _mobi_SalesContext.MobiCatagories.Where(w => w.StatusId == 1).Select(s => new MobiCatagory { Name = s.Name, Code = s.Code, Id = s.Id }).ToList();
            return data;
        }

        [HttpGet]
        [Route("getModelByProductId/{productId}")]
        public IList<MobiSubCatagory> GetModelByProductId(int productId)
        {
            var data = _mobi_SalesContext.MobiSubCatagories.Where(w => w.StatusId == 1 && w.CatagoryId == productId).Select(s => new MobiSubCatagory { Name = s.Name, Code = s.Code, Id = s.Id }).ToList();
            return data;
        }

        [HttpGet]
        [Route("getProductsByTypeId/{id}")]
        public IList<MobiCatagory> GetProductsByTypeId(int id)
        {
            var data = _mobi_SalesContext.MobiCatagories.Where(w => w.StatusId == 1 && w.CatType == id).Select(s => new MobiCatagory { Name = s.Name, Code = s.Code, Id = s.Id }).ToList();
            return data;
        }

        [HttpGet]
        [Route("getModel")]
        public IList<MobiSubCatagory> GetModel()
        {
            var data = _mobi_SalesContext.MobiSubCatagories.Where(w => w.StatusId == 1).Select(s => new MobiSubCatagory { Name = s.Name, Code = s.Code, Id = s.Id }).ToList();
            return data;
        }


        [HttpPost]
        [Route("saveProduct")]
        public object Add([FromBody] SaveProductModel saveProductModel)
        {
            DateTime curreDate = DateTime.UtcNow;
            MobiCatagory mobiCatagory = new MobiCatagory
            {
                BranchId = saveProductModel.BranchId,
                CatType = saveProductModel.CatType,
                Code = saveProductModel.Code,
                Name = saveProductModel.Name,
                CreatedBy = 1,
                CreatedDate = curreDate,
                UpdatedBy = 1,
                UpdatedDate = curreDate,
                StatusId = 1,
            };
            _mobi_SalesContext.MobiCatagories.Add(mobiCatagory);
            _mobi_SalesContext.SaveChanges();

            return new { Id = mobiCatagory.Id, Status = "Success" };
        }

        [HttpPut]
        [Route("updateProduct/{id}")]
        public object Update(int id, [FromBody] SaveProductModel saveProductModel)
        {
            DateTime curreDate = DateTime.UtcNow;
            MobiCatagory mobiCatagory = _mobi_SalesContext.MobiCatagories.FirstOrDefault(w => w.Id == id);

            mobiCatagory.Id = saveProductModel.Id.Value;
            mobiCatagory.BranchId = saveProductModel.BranchId;
            mobiCatagory.CatType = saveProductModel.CatType;
            mobiCatagory.Code = saveProductModel.Code;
            mobiCatagory.Name = saveProductModel.Name;
            mobiCatagory.UpdatedBy = 1;
            mobiCatagory.UpdatedDate = curreDate;
            mobiCatagory.StatusId = 1;

            _mobi_SalesContext.MobiCatagories.Add(mobiCatagory);
            _mobi_SalesContext.SaveChanges();

            return new { Id = mobiCatagory.Id, Status = "Success" };
        }
    }
}
