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
            await Service.InsertAsync(Model);
            return new Response<AnnounceDetail>
            {
                //Single = announceDetailResponse.Single,
                //Success = announceDetailResponse.Success, 
                //Message = announceDetailResponse.Message
            };
        }

        [HttpPut]
        [Route("api/announcedetail")]
        public async Task<Response<AnnounceDetail>> Update([FromBody] AnnounceDetailUpdateDataTransfer Model)
        {
            await Service.UpdateAsync(Model);
            return new Response<AnnounceDetail>
            {
                //Single = announceDetailResponse.Single,
                //Success = announceDetailResponse.Success, 
                //Message = announceDetailResponse.Message
            };
        }

        [HttpDelete]
        [Route("api/announcedetail")]
        public async Task<Response<AnnounceDetail>> Delete([FromBody] AnnounceDetailDeleteDataTransfer Model)
        {
            await Service.DeleteAsync(Model);
            return new Response<AnnounceDetail>
            {
                //Single = announceDetailResponse.Single,
                //Success = announceDetailResponse.Success, 
                //Message = announceDetailResponse.Message
            };
        }

        [HttpGet]
        [Route("api/announcedetail")]
        public async Task<Response<AnnounceDetail>> Get([FromBody] AnnounceDetailSelectDataTransfer Model)
        {
            await Service.SelectAsync(Model);
            return new Response<AnnounceDetail>
            {
                //Single = announceDetailResponse.Single,
                //Success = announceDetailResponse.Success, 
                //Message = announceDetailResponse.Message
            };
        }

        [HttpGet]
        [Route("api/announcedetail/{id}")]
        public async Task<Response<AnnounceDetail>> Get([FromBody] AnnounceDetailAnyDataTransfer Model)
        {
            await Service.AnyAsync(Model);
            return new Response<AnnounceDetail>
            {
                //Single = announceDetailResponse.Single,
                //Success = announceDetailResponse.Success, 
                //Message = announceDetailResponse.Message
            };
        }
    }
}