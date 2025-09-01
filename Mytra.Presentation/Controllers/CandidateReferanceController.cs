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
		[Route("api/candidatereferance")]
		[Produces(typeof(ServiceResponse<CandidateReferance>))]
		public async Task<ServiceResponse<CandidateReferance>> Create([FromBody] CandidateReferanceInsert Model)
		{
			DataService<CandidateReferance> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateReferance>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateReferance>.FailureResponse("");
			return ServiceResponse<CandidateReferance>.SuccessResponse(Response.Data, "");
		}

		//[HttpPut]
		//[Route("api/candidatereferance")]
		//[Produces(typeof(ServiceResponse<CandidateReferanceResponse>))]
		//public async Task<ServiceResponse<CandidateReferanceResponse>> Update([FromBody] CandidateReferanceUpdate Model)
		//{
		//	ServiceResponse<CandidateReferanceResponse> Response = await Service.UpdateAsync(Model);
		//	return new ServiceResponse<CandidateReferanceResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpDelete]
		//[Route("api/candidatereferance")]
		//[Produces(typeof(ServiceResponse<CandidateReferanceResponse>))]
		//public async Task<ServiceResponse<CandidateReferanceResponse>> Delete([FromBody] CandidateReferanceDelete Model)
		//{
		//	ServiceResponse<CandidateReferanceResponse> Response = await Service.DeleteAsync(Model);
		//	return new ServiceResponse<CandidateReferanceResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		[HttpGet]
		[Route("api/candidatereferance")]
		[Produces(typeof(ServiceResponse<CandidateReferance>))]
		public async Task<ServiceResponse<CandidateReferance>> Get([FromQuery] CandidateReferanceSelect Model)
		{
			DataService<CandidateReferance> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateReferance>.SuccessResponse(Response.DataList, "candidatereferance list");
		}

		//[HttpGet]
		//[Route("api/candidatereferancesingle")]
		//[Produces(typeof(ServiceResponse<CandidateReferanceResponse>))]
		//public async Task<ServiceResponse<CandidateReferanceResponse>> GetSingle([FromQuery] CandidateReferanceSelectSingle Model)
		//{
		//	ServiceResponse<CandidateReferanceResponse> Response = await Service.SelectSingleAsync(Model);
		//	return new ServiceResponse<CandidateReferanceResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}
	}
}