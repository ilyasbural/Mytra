namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
    public class CandidateDetailController : ControllerBase
    {
		private readonly ICandidateDetailService Service;
		public CandidateDetailController(ICandidateDetailService service) { Service = service; }

		[HttpPost]
		[Authorize]
		[Route("api/candidatedetail")]
		[Produces(typeof(ServiceResponse<CandidateDetailResponse>))]
		public async Task<ServiceResponse<CandidateDetailResponse>> Create([FromBody] CandidateDetailInsert Model)
		{
			ServiceResponse<CandidateDetailResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<CandidateDetailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Authorize]
		[Route("api/candidatedetail")]
		[Produces(typeof(ServiceResponse<CandidateDetailResponse>))]
		public async Task<ServiceResponse<CandidateDetailResponse>> Update([FromBody] CandidateDetailUpdate Model)
		{
			ServiceResponse<CandidateDetailResponse> Response = await Service.UpdateAsync(Model);
			return new ServiceResponse<CandidateDetailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Authorize]
		[Route("api/candidatedetail")]
		[Produces(typeof(ServiceResponse<CandidateDetailResponse>))]
		public async Task<ServiceResponse<CandidateDetailResponse>> Delete([FromBody] CandidateDetailDelete Model)
		{
			ServiceResponse<CandidateDetailResponse> Response = await Service.DeleteAsync(Model);
			return new ServiceResponse<CandidateDetailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidatedetail")]
		[Produces(typeof(ServiceResponse<CandidateDetailResponse>))]
		public async Task<ServiceResponse<CandidateDetailResponse>> Get([FromQuery] CandidateDetailSelect Model)
		{
			ServiceResponse<CandidateDetailResponse> Response = await Service.SelectAsync(Model);
			return new ServiceResponse<CandidateDetailResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidatedetailsingle")]
		[Produces(typeof(ServiceResponse<CandidateDetailResponse>))]
		public async Task<ServiceResponse<CandidateDetailResponse>> GetSingle([FromQuery] CandidateDetailSelectSingle Model)
		{
			ServiceResponse<CandidateDetailResponse> Response = await Service.SelectSingleAsync(Model);
			return new ServiceResponse<CandidateDetailResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}
	}
}