namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
    public class CandidateExperienceController : ControllerBase
    {
		readonly ICandidateExperienceService Service;
		public CandidateExperienceController(ICandidateExperienceService service) { Service = service; }

		[HttpPost]
		[Route("api/candidateexperience")]
		[Produces(typeof(ServiceResponse<CandidateExperienceResponse>))]
		public async Task<ServiceResponse<CandidateExperienceResponse>> Create([FromBody] CandidateExperienceInsert Model)
		{
			ServiceResponse<CandidateExperienceResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<CandidateExperienceResponse>
			{
				Success = Response.Success,
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/candidateexperience")]
		[Produces(typeof(ServiceResponse<CandidateExperienceResponse>))]
		public async Task<ServiceResponse<CandidateExperienceResponse>> Update([FromBody] CandidateExperienceUpdate Model)
		{
			ServiceResponse<CandidateExperienceResponse> Response = await Service.UpdateAsync(Model);
			return new ServiceResponse<CandidateExperienceResponse>
			{
				Success = Response.Success,
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/candidateexperience")]
		[Produces(typeof(ServiceResponse<CandidateExperienceResponse>))]
		public async Task<ServiceResponse<CandidateExperienceResponse>> Delete([FromBody] CandidateExperienceDelete Model)
		{
			ServiceResponse<CandidateExperienceResponse> Response = await Service.DeleteAsync(Model);
			return new ServiceResponse<CandidateExperienceResponse>
			{
				Success = Response.Success,
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidateexperience")]
		[Produces(typeof(ServiceResponse<CandidateExperienceResponse>))]
		public async Task<ServiceResponse<CandidateExperienceResponse>> Get([FromQuery] CandidateExperienceSelect Model)
		{
			ServiceResponse<CandidateExperienceResponse> Response = await Service.SelectAsync(Model);
			return new ServiceResponse<CandidateExperienceResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidateexperiencesingle")]
		[Produces(typeof(ServiceResponse<CandidateExperienceResponse>))]
		public async Task<ServiceResponse<CandidateExperienceResponse>> GetSingle([FromQuery] CandidateExperienceSelectSingle Model)
		{
			ServiceResponse<CandidateExperienceResponse> Response = await Service.SelectSingleAsync(Model);
			return new ServiceResponse<CandidateExperienceResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}
	}
}