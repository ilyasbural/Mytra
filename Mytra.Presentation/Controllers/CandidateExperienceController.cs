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

		//[HttpPost]
		//[Route("api/candidateexperience")]
		//[Produces(typeof(ServiceResponse<CandidateExperienceResponse>))]
		//public async Task<ServiceResponse<CandidateExperienceResponse>> Create([FromBody] CandidateExperienceInsert Model)
		//{
		//	ServiceResponse<CandidateExperienceResponse> Response = await Service.InsertAsync(Model);
		//	return new ServiceResponse<CandidateExperienceResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpPut]
		//[Route("api/candidateexperience")]
		//[Produces(typeof(ServiceResponse<CandidateExperienceResponse>))]
		//public async Task<ServiceResponse<CandidateExperienceResponse>> Update([FromBody] CandidateExperienceUpdate Model)
		//{
		//	ServiceResponse<CandidateExperienceResponse> Response = await Service.UpdateAsync(Model);
		//	return new ServiceResponse<CandidateExperienceResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpDelete]
		//[Route("api/candidateexperience")]
		//[Produces(typeof(ServiceResponse<CandidateExperienceResponse>))]
		//public async Task<ServiceResponse<CandidateExperienceResponse>> Delete([FromBody] CandidateExperienceDelete Model)
		//{
		//	ServiceResponse<CandidateExperienceResponse> Response = await Service.DeleteAsync(Model);
		//	return new ServiceResponse<CandidateExperienceResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		[HttpGet]
		[Route("api/candidateexperience")]
		[Produces(typeof(ServiceResponse<CandidateExperience>))]
		public async Task<ServiceResponse<CandidateExperience>> Get([FromQuery] CandidateExperienceSelect Model)
		{
			DataService<CandidateExperience> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateExperience>.SuccessResponse(Response.DataList, "candidateexperience list");
		}

		//[HttpGet]
		//[Route("api/candidateexperiencesingle")]
		//[Produces(typeof(ServiceResponse<CandidateExperienceResponse>))]
		//public async Task<ServiceResponse<CandidateExperienceResponse>> GetSingle([FromQuery] CandidateExperienceSelectSingle Model)
		//{
		//	ServiceResponse<CandidateExperienceResponse> Response = await Service.SelectSingleAsync(Model);
		//	return new ServiceResponse<CandidateExperienceResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}
	}
}