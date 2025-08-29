namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
    public class CandidateEducationController : ControllerBase
    {
		readonly ICandidateEducationService Service;
		public CandidateEducationController(ICandidateEducationService service) { Service = service; }

		[HttpPost]
		[Authorize]
		[Route("api/candidateeducation")]
		[Produces(typeof(ServiceResponse<CandidateEducationResponse>))]
		public async Task<ServiceResponse<CandidateEducationResponse>> Create([FromBody] CandidateEducationInsert Model)
		{
			ServiceResponse<CandidateEducationResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<CandidateEducationResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Authorize]
		[Route("api/candidateeducation")]
		[Produces(typeof(ServiceResponse<CandidateEducationResponse>))]
		public async Task<ServiceResponse<CandidateEducationResponse>> Update([FromBody] CandidateEducationUpdate Model)
		{
			ServiceResponse<CandidateEducationResponse> Response = await Service.UpdateAsync(Model);
			return new ServiceResponse<CandidateEducationResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Authorize]
		[Route("api/candidateeducation")]
		[Produces(typeof(ServiceResponse<CandidateEducationResponse>))]
		public async Task<ServiceResponse<CandidateEducationResponse>> Delete([FromBody] CandidateEducationDelete Model)
		{
			ServiceResponse<CandidateEducationResponse> Response = await Service.DeleteAsync(Model);
			return new ServiceResponse<CandidateEducationResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidateeducation")]
		[Produces(typeof(ServiceResponse<CandidateEducationResponse>))]
		public async Task<ServiceResponse<CandidateEducationResponse>> Get([FromQuery] CandidateEducationSelect Model)
		{
			ServiceResponse<CandidateEducationResponse> Response = await Service.SelectAsync(Model);
			return new ServiceResponse<CandidateEducationResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidateeducationsingle")]
		[Produces(typeof(ServiceResponse<CandidateEducationResponse>))]
		public async Task<ServiceResponse<CandidateEducationResponse>> GetSingle([FromQuery] CandidateEducationSelectSingle Model)
		{
			ServiceResponse<CandidateEducationResponse> Response = await Service.SelectSingleAsync(Model);
			return new ServiceResponse<CandidateEducationResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}
	}
}