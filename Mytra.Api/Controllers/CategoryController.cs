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
        public async Task<CategoryWebResponse> Create([FromBody] CategoryInsertDataTransfer Model)
        {
            CategoryResponse categoryResponse = await Service.AddAsync(Model);
            return new CategoryWebResponse
            {
                


            };
        }

        [HttpPut]
        [Route("api/category")]
        public async Task<CategoryWebResponse> Update([FromBody] CategoryUpdateDataTransfer Model)
        {
            CategoryResponse categoryResponse = await Service.UpdateAsync(Model);
            return new CategoryWebResponse
            {



            };
        }

        [HttpDelete]
        [Route("api/category")]
        public async Task<CategoryWebResponse> Delete([FromBody] CategoryDeleteDataTransfer Model)
        {
            CategoryResponse categoryResponse = await Service.DeleteAsync(Model);
            return new CategoryWebResponse
            {



            };
        }
    }
}