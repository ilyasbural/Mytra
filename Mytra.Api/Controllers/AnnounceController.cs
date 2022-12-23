namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class AnnounceController : ControllerBase
    {
        readonly IAnnounceService Service;
        public AnnounceController(IAnnounceService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/announce")]
        public async Task<Response<Announce>> Create([FromBody] AnnounceInsertDataTransfer Model)
        {
            await Service.InsertAsync(Model);
            return new Response<Announce> 
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
        [Route("api/announce")]
        public async Task<Response<Announce>> Update([FromBody] AnnounceUpdateDataTransfer Model)
        {
            await Service.UpdateAsync(Model);
            return new Response<Announce>
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
        [Route("api/announce")]
        public async Task<Response<Announce>> Delete([FromBody] AnnounceDeleteDataTransfer Model)
        {
            await Service.DeleteAsync(Model);
            return new Response<Announce>
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
        [Route("api/announce")]
        public async Task<Response<Announce>> Get([FromBody] AnnounceSelectDataTransfer Model)
        {
            await Service.SelectAsync(Model);
            return new Response<Announce>
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
        [Route("api/announce/{id}")]
        public async Task<Response<Announce>> Get([FromBody] AnnounceAnyDataTransfer Model)
        {
            await Service.AnySelectAsync(Model);
            return new Response<Announce>
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