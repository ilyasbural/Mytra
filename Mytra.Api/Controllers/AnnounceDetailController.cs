namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class AnnounceDetailController : ControllerBase
    {
        private readonly IAnnounceDetailService Service;
        public AnnounceDetailController(IAnnounceDetailService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/announcedetail")]
        public async Task<AnnounceDetailWebResponse> Create([FromBody] AnnounceDetailInsertDataTransfer Model)
        {
            AnnounceDetailResponse announceDetailResponse = await Service.AddAsync(Model);
            return new AnnounceDetailWebResponse { AnnounceDetail = announceDetailResponse.AnnounceDetail };
        }

        [HttpPut]
        [Route("api/announcedetail")]
        public async Task<AnnounceDetailWebResponse> Update([FromBody] AnnounceDetailUpdateDataTransfer Model)
        {
            AnnounceDetailResponse announceDetailResponse = await Service.UpdateAsync(Model);
            return new AnnounceDetailWebResponse
            {



            };
        }

        [HttpDelete]
        [Route("api/announcedetail")]
        public async Task<AnnounceDetailWebResponse> Delete([FromBody] AnnounceDetailDeleteDataTransfer Model)
        {
            AnnounceDetailResponse announceDetailResponse = await Service.DeleteAsync(Model);
            return new AnnounceDetailWebResponse
            {



            };
        }

        [HttpGet]
        [Route("api/announcedetail")]
        public async Task<AnnounceDetailWebResponse> Get([FromBody] AnnounceDetailSelectDataTransfer Model)
        {
            AnnounceDetailResponse announceResponse = await Service.SelectAsync(Model);
            return new AnnounceDetailWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/announcedetail/{id}")]
        public async Task<AnnounceWebResponse> Get([FromBody] AnnounceDetailAnyDataTransfer Model)
        {
            AnnounceDetailResponse announceResponse = await Service.AnyAsync(Model);
            return new AnnounceWebResponse
            {


            };
        }
    }
}