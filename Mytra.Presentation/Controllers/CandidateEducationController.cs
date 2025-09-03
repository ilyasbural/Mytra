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
		[Produces(typeof(ServiceResponse<CandidateEducation>))]
		public async Task<ServiceResponse<CandidateEducation>> Create([FromBody] CandidateEducationInsert Model)
		{
			DataService<CandidateEducation> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateEducation>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateEducation>.FailureResponse("");
			return ServiceResponse<CandidateEducation>.SuccessResponse(Response.Data, "");
		}

		[HttpPut]
		[Authorize]
		[Route("api/candidateeducation")]
		[Produces(typeof(ServiceResponse<CandidateEducation>))]
		public async Task<ServiceResponse<CandidateEducation>> Update([FromBody] CandidateEducationUpdate Model)
		{
			DataService<CandidateEducation> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateEducation>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateEducation>.FailureResponse("");
			return ServiceResponse<CandidateEducation>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Authorize]
		[Route("api/candidateeducation")]
		[Produces(typeof(ServiceResponse<CandidateEducation>))]
		public async Task<ServiceResponse<CandidateEducation>> Delete([FromBody] CandidateEducationDelete Model)
		{
			DataService<CandidateEducation> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateEducation>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateEducation>.FailureResponse("");
			return ServiceResponse<CandidateEducation>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidateeducation")]
		[Produces(typeof(ServiceResponse<CandidateEducation>))]
		public async Task<ServiceResponse<CandidateEducation>> Get([FromQuery] CandidateEducationSelect Model)
		{
			DataService<CandidateEducation> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateEducation>.SuccessResponse(Response.DataList, "candidateeducation list");
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidateeducationsingle")]
		[Produces(typeof(ServiceResponse<CandidateEducation>))]
		public async Task<ServiceResponse<CandidateEducation>> GetSingle([FromQuery] CandidateEducationSelectSingle Model)
		{
			DataService<CandidateEducation> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CandidateEducation>.SuccessResponse(Response.Data, "");
		}
	}
}