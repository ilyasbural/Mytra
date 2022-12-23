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
            await Service.InsertAsync(Model);
            return new Response<Category>
            {
                //Single = Response.Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        [HttpPut]
        [Route("api/category")]
        public async Task<Response<Category>> Update([FromBody] CategoryUpdateDataTransfer Model)
        {
            await Service.UpdateAsync(Model);
            return new Response<Category>
            {
                //Single = Response.Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        [HttpDelete]
        [Route("api/category")]
        public async Task<Response<Category>> Delete([FromBody] CategoryDeleteDataTransfer Model)
        {
            await Service.DeleteAsync(Model);
            return new Response<Category>
            {
                //Single = Response.Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        [HttpGet]
        [Route("api/category")]
        public async Task<Response<Category>> Get([FromBody] CategorySelectDataTransfer Model)
        {
            await Service.SelectAsync(Model);
            return new Response<Category>
            {
                //Single = Response.Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }

        [HttpGet]
        [Route("api/category/{id}")]
        public async Task<Response<Category>> Get([FromBody] CategoryAnyDataTransfer Model)
        {
            await Service.AnySelectAsync(Model);
            return new Response<Category>
            {
                //Single = Response.Entity,
                //Success = Success,
                //Message = Message,
                //Errors = new List<string>(),
                //IsValidationError = IsValidationError,
                //Validations = new List<ValidationResult> { Validations }
            };
        }
    }
}