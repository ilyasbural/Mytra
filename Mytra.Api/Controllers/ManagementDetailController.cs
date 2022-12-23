namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class ManagementDetailController : ControllerBase
    {
        readonly IManagementDetailService Service;
        public ManagementDetailController(IManagementDetailService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/managementdetail")]
        public async Task<Response<ManagementDetail>> Create([FromBody] ManagementDetailInsertDataTransfer Model)
        {
            await Service.InsertAsync(Model);
            return new Response<ManagementDetail>
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
        [Route("api/managementdetail")]
        public async Task<Response<ManagementDetail>> Update([FromBody] ManagementDetailUpdateDataTransfer Model)
        {
            await Service.UpdateAsync(Model);
            return new Response<ManagementDetail>
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
        [Route("api/managementdetail")]
        public async Task<Response<ManagementDetail>> Delete([FromBody] ManagementDetailDeleteDataTransfer Model)
        {
            await Service.DeleteAsync(Model);
            return new Response<ManagementDetail>
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
        [Route("api/managementdetail")]
        public async Task<Response<ManagementDetail>> Get([FromBody] ManagementDetailSelectDataTransfer Model)
        {
            await Service.SelectAsync(Model);
            return new Response<ManagementDetail>
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
        [Route("api/managementdetail/{id}")]
        public async Task<Response<ManagementDetail>> Get([FromBody] ManagementDetailAnyDataTransfer Model)
        {
            await Service.AnySelectAsync(Model);
            return new Response<ManagementDetail>
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