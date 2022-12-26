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
        public async Task<Response<Category>> Create([FromBody] CategoryInsertDataTransfer Model)
        {
            Response<Category> Response = await Service.InsertAsync(Model);
            return new Response<Category>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/category")]
        public async Task<Response<Category>> Update([FromBody] CategoryUpdateDataTransfer Model)
        {
            Response<Category> Response = await Service.UpdateAsync(Model);
            return new Response<Category>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/category")]
        public async Task<Response<Category>> Delete([FromBody] CategoryDeleteDataTransfer Model)
        {
            Response<Category> Response = await Service.DeleteAsync(Model);
            return new Response<Category>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/category")]
        public async Task<Response<Category>> Get([FromBody] CategorySelectDataTransfer Model)
        {
            Response<Category> Response = await Service.SelectAsync(Model);
            return new Response<Category>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/category/{id}")]
        public async Task<Response<Category>> Get([FromBody] CategoryAnyDataTransfer Model)
        {
            Response<Category> Response = await Service.AnySelectAsync(Model);
            return new Response<Category>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}