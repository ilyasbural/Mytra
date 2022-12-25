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
            Response<Announce> Response = await Service.InsertAsync(Model);
            return new Response<Announce> 
            {
                Data = Response.Data,
                Message = Response.Message, 
                Success = Response.Success, 
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/announce")]
        public async Task<Response<Announce>> Update([FromBody] AnnounceUpdateDataTransfer Model)
        {
            Response<Announce> Response = await Service.UpdateAsync(Model);
            return new Response<Announce>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/announce")]
        public async Task<Response<Announce>> Delete([FromBody] AnnounceDeleteDataTransfer Model)
        {
            Response<Announce> Response = await Service.DeleteAsync(Model);
            return new Response<Announce>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/announce")]
        public async Task<Response<Announce>> Get([FromBody] AnnounceSelectDataTransfer Model)
        {
            Response<Announce> Response = await Service.SelectAsync(Model);
            return new Response<Announce>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/announce/{id}")]
        public async Task<Response<Announce>> Get([FromBody] AnnounceAnyDataTransfer Model)
        {
            Response<Announce> Response = await Service.AnySelectAsync(Model);
            return new Response<Announce>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}