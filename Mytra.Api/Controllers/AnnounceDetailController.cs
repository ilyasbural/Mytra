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
            return new AnnounceDetailWebResponse
            {
                


            };
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
    }
}