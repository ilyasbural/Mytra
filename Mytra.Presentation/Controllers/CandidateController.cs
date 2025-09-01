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
		[Route("api/candidate")]
		[Produces(typeof(ServiceResponse<Candidate>))]
		public async Task<ServiceResponse<Candidate>> Create([FromBody] CandidateInsert Model)
		{
			DataService<Candidate> Response = await Service.InsertAsync(Model);		
			if (Response.Errors.Count > 0) return ServiceResponse<Candidate>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<Candidate>.FailureResponse("");
			return ServiceResponse<Candidate>.SuccessResponse(Response.Data, "");
		}

		[HttpPut]
		[Route("api/candidate")]
		[Produces(typeof(ServiceResponse<Candidate>))]
		public async Task<ServiceResponse<Candidate>> Update([FromBody] CandidateUpdate Model)
		{
			DataService<Candidate> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<Candidate>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<Candidate>.FailureResponse("");
			return ServiceResponse<Candidate>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Route("api/candidate")]
		[Produces(typeof(ServiceResponse<Candidate>))]
		public async Task<ServiceResponse<Candidate>> Delete([FromBody] CandidateDelete Model)
		{
			DataService<Candidate> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<Candidate>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<Candidate>.FailureResponse("");
			return ServiceResponse<Candidate>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/candidate")]
		[Produces(typeof(ServiceResponse<Candidate>))]
		public async Task<ServiceResponse<Candidate>> Get([FromQuery] CandidateSelect Model)
		{
			DataService<Candidate> Response = await Service.SelectAsync(Model);
			return ServiceResponse<Candidate>.SuccessResponse(Response.DataList, "");
		}

		[HttpGet]
		[Route("api/candidatesingle")]
		[Produces(typeof(ServiceResponse<Candidate>))]
		public async Task<ServiceResponse<Candidate>> GetSingle([FromQuery] CandidateSelectSingle Model)
		{
			DataService<Candidate> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<Candidate>.SuccessResponse(Response.Data, "");
		}
	}
}