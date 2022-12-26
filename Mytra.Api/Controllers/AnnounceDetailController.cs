namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class AnnounceDetailController : ControllerBase
    {
        readonly IAnnounceDetailService Service;
        public AnnounceDetailController(IAnnounceDetailService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/announcedetail")]
        public async Task<Response<AnnounceDetail>> Create([FromBody] AnnounceDetailInsertDataTransfer Model)
        {
            Response<AnnounceDetail> Response = await Service.InsertAsync(Model);
            return new Response<AnnounceDetail>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpPut]
        [Route("api/announcedetail")]
        public async Task<Response<AnnounceDetail>> Update([FromBody] AnnounceDetailUpdateDataTransfer Model)
        {
            Response<AnnounceDetail> Response = await Service.UpdateAsync(Model);
            return new Response<AnnounceDetail>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpDelete]
        [Route("api/announcedetail")]
        public async Task<Response<AnnounceDetail>> Delete([FromBody] AnnounceDetailDeleteDataTransfer Model)
        {
            Response<AnnounceDetail> Response = await Service.DeleteAsync(Model);
            return new Response<AnnounceDetail>
            {
                Data = Response.Data,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/announcedetail")]
        public async Task<Response<AnnounceDetail>> Get([FromBody] AnnounceDetailSelectDataTransfer Model)
        {
            Response<AnnounceDetail> Response = await Service.SelectAsync(Model);
            return new Response<AnnounceDetail>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }

        [HttpGet]
        [Route("api/announcedetail/{id}")]
        public async Task<Response<AnnounceDetail>> Get([FromBody] AnnounceDetailAnyDataTransfer Model)
        {
            Response<AnnounceDetail> Response = await Service.AnyAsync(Model);
            return new Response<AnnounceDetail>
            {
                Collection = Response.Collection,
                Message = Response.Message,
                Success = Response.Success,
                IsValidationError = Response.IsValidationError
            };
        }
    }
}