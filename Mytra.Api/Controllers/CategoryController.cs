namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class CategoryController : ControllerBase
    {
        readonly ICategoryService Service;
        public CategoryController(ICategoryService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/category")]
        public async Task<CategoryWebResponse> Create([FromBody] CategoryInsertDataTransfer Model)
        {
            CategoryResponse categoryResponse = await Service.InsertAsync(Model);
            return new CategoryWebResponse 
            { 
                Single = categoryResponse.Single, 
                Success = categoryResponse.Success, 
                Message = categoryResponse.Message
            };
        }

        [HttpPut]
        [Route("api/category")]
        public async Task<CategoryWebResponse> Update([FromBody] CategoryUpdateDataTransfer Model)
        {
            CategoryResponse categoryResponse = await Service.UpdateAsync(Model);
            return new CategoryWebResponse
            {
                Single = categoryResponse.Single,
                Success = categoryResponse.Success,
                Message = categoryResponse.Message
            };
        }

        [HttpDelete]
        [Route("api/category")]
        public async Task<CategoryWebResponse> Delete([FromBody] CategoryDeleteDataTransfer Model)
        {
            CategoryResponse categoryResponse = await Service.DeleteAsync(Model);
            return new CategoryWebResponse
            {
                Single = categoryResponse.Single,
                Success = categoryResponse.Success,
                Message = categoryResponse.Message
            };
        }

        [HttpGet]
        [Route("api/category")]
        public async Task<CategoryWebResponse> Get([FromBody] CategorySelectDataTransfer Model)
        {
            CategoryResponse categoryResponse = await Service.SelectAsync(Model);
            return new CategoryWebResponse
            {
                List = categoryResponse.List,
                Success = categoryResponse.Success, 
                Message = categoryResponse.Message
            };
        }

        [HttpGet]
        [Route("api/category/{id}")]
        public async Task<CategoryWebResponse> Get([FromBody] CategoryAnyDataTransfer Model)
        {
            CategoryResponse categoryResponse = await Service.AnyAsync(Model);
            return new CategoryWebResponse
            {
                List = categoryResponse.List,
                Success = categoryResponse.Success,
                Message = categoryResponse.Message
            };
        }
    }
}