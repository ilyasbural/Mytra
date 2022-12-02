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

        [HttpDelete]
        [Route("api/announce")]
        public async Task<AnnounceWebResponse> Delete([FromBody] AnnounceDeleteDataTransfer Model)
        {
            AnnounceResponse announceResponse = await Service.DeleteAsync(Model);
            return new AnnounceWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/announce")]
        public async Task<AnnounceWebResponse> Get([FromBody] AnnounceSelectDataTransfer Model)
        {
            AnnounceResponse announceResponse = await Service.SelectAsync(Model);
            return new AnnounceWebResponse
            {


            };
        }

        [HttpGet]
        [Route("api/announce/{id}")]
        public async Task<AnnounceWebResponse> Get([FromBody] AnnounceAnyDataTransfer Model)
        {
            AnnounceResponse announceResponse = await Service.AnyAsync(Model);
            return new AnnounceWebResponse
            {


            };
        }
    }
}