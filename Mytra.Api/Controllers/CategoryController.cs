namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService Service;
        public CategoryController(ICategoryService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/category")]
        public Task<CategoryWebResponse> Create([FromBody] CategoryInsertDataTransfer Model)
        {
            Task<CategoryResponse> Data = Service.AddAsync(Model);
            //AnnounceResult Result = Service.AddAsync(Model);
            //return new AnnounceResponse
            //{
            //    Id = Result.Id,
            //    Company = Result.Company,
            //    Occupation = Result.Occupation,
            //    Title = Result.Title,
            //    AnnounceDate = Result.AnnounceDate,
            //    CreatedByUser = Result.CreatedByUser,
            //    UpdatedByUser = Result.UpdatedByUser,
            //    RegisterDate = Result.RegisterDate,
            //    UpdateDate = Result.UpdateDate
            //};
            return Create(Model);
        }
    }
}