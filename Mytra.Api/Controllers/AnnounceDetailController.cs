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
        public async Task<AnnounceDetailWebResponse> Create([FromBody] AnnounceDetailInsertDataTransfer Model)
        {
            AnnounceDetailResponse announceDetailResponse = await Service.InsertAsync(Model);
            return new AnnounceDetailWebResponse 
            { 
                Single = announceDetailResponse.Single, 
                Success = announceDetailResponse.Success, 
                Message = announceDetailResponse.Message
            };
        }

        [HttpPut]
        [Route("api/announcedetail")]
        public async Task<AnnounceDetailWebResponse> Update([FromBody] AnnounceDetailUpdateDataTransfer Model)
        {
            AnnounceDetailResponse announceDetailResponse = await Service.UpdateAsync(Model);
            return new AnnounceDetailWebResponse
            {
                Single = announceDetailResponse.Single,
                Success = announceDetailResponse.Success, 
                Message = announceDetailResponse.Message
            };
        }

        [HttpDelete]
        [Route("api/announcedetail")]
        public async Task<AnnounceDetailWebResponse> Delete([FromBody] AnnounceDetailDeleteDataTransfer Model)
        {
            AnnounceDetailResponse announceDetailResponse = await Service.DeleteAsync(Model);
            return new AnnounceDetailWebResponse
            {
                Single = announceDetailResponse.Single,
                Success = announceDetailResponse.Success, 
                Message = announceDetailResponse.Message
            };
        }

        [HttpGet]
        [Route("api/announcedetail")]
        public async Task<AnnounceDetailWebResponse> Get([FromBody] AnnounceDetailSelectDataTransfer Model)
        {
            AnnounceDetailResponse announceDetailResponse = await Service.SelectAsync(Model);
            return new AnnounceDetailWebResponse
            {
                List = announceDetailResponse.List, 
                Success = announceDetailResponse.Success, 
                Message = announceDetailResponse.Message
            };
        }

        [HttpGet]
        [Route("api/announcedetail/{id}")]
        public async Task<AnnounceDetailWebResponse> Get([FromBody] AnnounceDetailAnyDataTransfer Model)
        {
            AnnounceDetailResponse announceDetailResponse = await Service.AnyAsync(Model);
            return new AnnounceDetailWebResponse
            {
                List = announceDetailResponse.List, 
                Success = announceDetailResponse.Success, 
                Message = announceDetailResponse.Message
            };
        }
    }
}