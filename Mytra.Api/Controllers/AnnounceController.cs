namespace Mytra.Api.Controllers
{
    using Core;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class AnnounceController : ControllerBase
    {
        private readonly IAnnounceService Service;
        public AnnounceController(IAnnounceService service)
        {
            Service = service;
        }

        [HttpPost]
        [Route("api/announce")]
        public async Task<AnnounceWebResponse> Create([FromBody] AnnounceInsertDataTransfer Model)
        {
            AnnounceResponse announceResponse = await Service.AddAsync(Model);
            return new AnnounceWebResponse
            {
                



            };
        }

        [HttpPut]
        [Route("api/announce")]
        public async Task<AnnounceWebResponse> Update([FromBody] AnnounceUpdateDataTransfer Model)
        {
            AnnounceResponse announceResponse = await Service.UpdateAsync(Model);
            return new AnnounceWebResponse
            {





            };
        }
    }
}