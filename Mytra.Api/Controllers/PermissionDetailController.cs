namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class PermissionDetailController : ControllerBase
    {
        readonly IPermissionDetailService Service;
        public PermissionDetailController(IPermissionDetailService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/permissiondetail")]
        public async Task<Response<PermissionDetail>> Create([FromBody] PermissionDetailInsertDataTransfer Model)
        {
            await Service.InsertAsync(Model);
            return new Response<PermissionDetail>
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
        [Route("api/permissiondetail")]
        public async Task<Response<PermissionDetail>> Update([FromBody] PermissionDetailUpdateDataTransfer Model)
        {
            await Service.UpdateAsync(Model);
            return new Response<PermissionDetail>
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
        [Route("api/permissiondetail")]
        public async Task<Response<PermissionDetail>> Delete([FromBody] PermissionDetailDeleteDataTransfer Model)
        {
            await Service.DeleteAsync(Model);
            return new Response<PermissionDetail>
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
        [Route("api/permissiondetail")]
        public async Task<Response<PermissionDetail>> Get([FromBody] PermissionDetailSelectDataTransfer Model)
        {
            await Service.SelectAsync(Model);
            return new Response<PermissionDetail>
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
        [Route("api/permissiondetail/{id}")]
        public async Task<Response<PermissionDetail>> Get([FromBody] PermissionDetailAnyDataTransfer Model)
        {
            await Service.AnySelectAsync(Model);
            return new Response<PermissionDetail>
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