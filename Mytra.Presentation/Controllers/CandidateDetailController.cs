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