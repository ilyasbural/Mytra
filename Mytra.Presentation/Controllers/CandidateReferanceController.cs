namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

    [ApiController]
    public class CandidateReferanceController : ControllerBase
    {
		readonly ICandidateReferanceService Service;
		public CandidateReferanceController(ICandidateReferanceService service) { Service = service; }

		[HttpPost]
		[Authorize]
		[Route("api/candidatereferance")]
		[Produces(typeof(ServiceResponse<CandidateReferance>))]
		public async Task<ServiceResponse<CandidateReferance>> Create([FromBody] CandidateReferanceInsert Model)
		{
			DataService<CandidateReferance> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateReferance>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateReferance>.FailureResponse("");
			return ServiceResponse<CandidateReferance>.SuccessResponse(Response.Data, "");
		}

		[HttpPut]
		[Authorize]
		[Route("api/candidatereferance")]
		[Produces(typeof(ServiceResponse<CandidateReferance>))]
		public async Task<ServiceResponse<CandidateReferance>> Update([FromBody] CandidateReferanceUpdate Model)
		{
			DataService<CandidateReferance> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateReferance>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateReferance>.FailureResponse("");
			return ServiceResponse<CandidateReferance>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Authorize]
		[Route("api/candidatereferance")]
		[Produces(typeof(ServiceResponse<CandidateReferance>))]
		public async Task<ServiceResponse<CandidateReferance>> Delete([FromBody] CandidateReferanceDelete Model)
		{
			DataService<CandidateReferance> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateReferance>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateReferance>.FailureResponse("");
			return ServiceResponse<CandidateReferance>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidatereferance")]
		[Produces(typeof(ServiceResponse<CandidateReferance>))]
		public async Task<ServiceResponse<CandidateReferance>> Get([FromQuery] CandidateReferanceSelect Model)
		{
			DataService<CandidateReferance> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateReferance>.SuccessResponse(Response.DataList, "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidatereferancesingle")]
		[Produces(typeof(ServiceResponse<CandidateReferance>))]
		public async Task<ServiceResponse<CandidateReferance>> GetSingle([FromQuery] CandidateReferanceSelectSingle Model)
		{
			DataService<CandidateReferance> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CandidateReferance>.SuccessResponse(Response.Data, "");
		}
	}
}