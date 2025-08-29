namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

    [ApiController]
    public class CandidateController : ControllerBase
    {
		readonly ICandidateService Service;
		public CandidateController(ICandidateService service) { Service = service; }

		[HttpPost]
		[Authorize]
		[Route("api/candidate")]
		[Produces(typeof(ServiceResponse<CandidateResponse>))]
		public async Task<ServiceResponse<CandidateResponse>> Create([FromBody] CandidateInsert Model)
		{
			ServiceResponse<CandidateResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<CandidateResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Authorize]
		[Route("api/candidate")]
		[Produces(typeof(ServiceResponse<CandidateResponse>))]
		public async Task<ServiceResponse<CandidateResponse>> Update([FromBody] CandidateUpdate Model)
		{
			ServiceResponse<CandidateResponse> Response = await Service.UpdateAsync(Model);
			return new ServiceResponse<CandidateResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Authorize]
		[Route("api/candidate")]
		[Produces(typeof(ServiceResponse<CandidateResponse>))]
		public async Task<ServiceResponse<CandidateResponse>> Delete([FromBody] CandidateDelete Model)
		{
			ServiceResponse<CandidateResponse> Response = await Service.DeleteAsync(Model);
			return new ServiceResponse<CandidateResponse>
			{
				ResponseData = Response.ResponseData
			};
		}
	}
}