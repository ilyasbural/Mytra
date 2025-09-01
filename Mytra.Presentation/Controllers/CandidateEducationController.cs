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
		[Route("api/candidateeducation")]
		[Produces(typeof(ServiceResponse<CandidateEducation>))]
		public async Task<ServiceResponse<CandidateEducation>> Create([FromBody] CandidateEducationInsert Model)
		{
			DataService<CandidateEducation> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateEducation>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateEducation>.FailureResponse("");
			return ServiceResponse<CandidateEducation>.SuccessResponse(Response.Data, "");
		}

		//[HttpPut]
		//[Route("api/candidateeducation")]
		//[Produces(typeof(ServiceResponse<CandidateEducationResponse>))]
		//public async Task<ServiceResponse<CandidateEducationResponse>> Update([FromBody] CandidateEducationUpdate Model)
		//{
		//	ServiceResponse<CandidateEducationResponse> Response = await Service.UpdateAsync(Model);
		//	return new ServiceResponse<CandidateEducationResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpDelete]
		//[Route("api/candidateeducation")]
		//[Produces(typeof(ServiceResponse<CandidateEducationResponse>))]
		//public async Task<ServiceResponse<CandidateEducationResponse>> Delete([FromBody] CandidateEducationDelete Model)
		//{
		//	ServiceResponse<CandidateEducationResponse> Response = await Service.DeleteAsync(Model);
		//	return new ServiceResponse<CandidateEducationResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		[HttpGet]
		[Route("api/candidateeducation")]
		[Produces(typeof(ServiceResponse<CandidateEducation>))]
		public async Task<ServiceResponse<CandidateEducation>> Get([FromQuery] CandidateEducationSelect Model)
		{
			DataService<CandidateEducation> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateEducation>.SuccessResponse(Response.DataList, "candidateeducation list");
		}

		//[HttpGet]
		//[Route("api/candidateeducationsingle")]
		//[Produces(typeof(ServiceResponse<CandidateEducationResponse>))]
		//public async Task<ServiceResponse<CandidateEducationResponse>> GetSingle([FromQuery] CandidateEducationSelectSingle Model)
		//{
		//	ServiceResponse<CandidateEducationResponse> Response = await Service.SelectSingleAsync(Model);
		//	return new ServiceResponse<CandidateEducationResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}
	}
}