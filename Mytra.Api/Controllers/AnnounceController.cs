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
        public async Task<AnnounceWebResponse> Create([FromBody] AnnounceInsertDataTransfer Model)
        {
            AnnounceResponse announceResponse = await Service.InsertAsync(Model);
            return new AnnounceWebResponse 
            { 
                Single = announceResponse.Single, 
                Success = announceResponse.Success 
            };
        }

        [HttpPut]
        [Route("api/announce")]
        public async Task<AnnounceWebResponse> Update([FromBody] AnnounceUpdateDataTransfer Model)
        {
            AnnounceResponse announceResponse = await Service.UpdateAsync(Model);
            return new AnnounceWebResponse
            {
                Single = announceResponse.Single,
                Success = announceResponse.Success
            };
        }

        [HttpDelete]
        [Route("api/announce")]
        public async Task<AnnounceWebResponse> Delete([FromBody] AnnounceDeleteDataTransfer Model)
        {
            AnnounceResponse announceResponse = await Service.DeleteAsync(Model);
            return new AnnounceWebResponse
            {
                Success = announceResponse.Success
            };
        }

        [HttpGet]
        [Route("api/announce")]
        public async Task<AnnounceWebResponse> Get([FromBody] AnnounceSelectDataTransfer Model)
        {
            AnnounceResponse announceResponse = await Service.SelectAsync(Model);
            return new AnnounceWebResponse
            {
                List = announceResponse.List, 
                Success = announceResponse.Success, 
                Message = announceResponse.Message
            };
        }

        [HttpGet]
        [Route("api/announce/{id}")]
        public async Task<AnnounceWebResponse> Get([FromBody] AnnounceAnyDataTransfer Model)
        {
            AnnounceResponse announceResponse = await Service.AnyAsync(Model);
            return new AnnounceWebResponse
            {
                List = announceResponse.List,
                Success = announceResponse.Success, 
                Message = announceResponse.Message
            };
        }
    }
}