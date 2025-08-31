namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

    [ApiController]
    public class CandidateSettingsController : ControllerBase
    {
		//readonly ICandidateSettingsService Service;
		//public CandidateSettingsController(ICandidateSettingsService service) { Service = service; }

		//[HttpPost]
		//[Route("api/candidatesettings")]
		//[Produces(typeof(ServiceResponse<CandidateSettingsResponse>))]
		//public async Task<ServiceResponse<CandidateSettingsResponse>> Create([FromBody] CandidateSettingsInsert Model)
		//{
		//	ServiceResponse<CandidateSettingsResponse> Response = await Service.InsertAsync(Model);
		//	return new ServiceResponse<CandidateSettingsResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpPut]
		//[Route("api/candidatesettings")]
		//[Produces(typeof(ServiceResponse<CandidateSettingsResponse>))]
		//public async Task<ServiceResponse<CandidateSettingsResponse>> Update([FromBody] CandidateSettingsUpdate Model)
		//{
		//	ServiceResponse<CandidateSettingsResponse> Response = await Service.UpdateAsync(Model);
		//	return new ServiceResponse<CandidateSettingsResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpDelete]
		//[Route("api/candidatesettings")]
		//[Produces(typeof(ServiceResponse<CandidateSettingsResponse>))]
		//public async Task<ServiceResponse<CandidateSettingsResponse>> Delete([FromBody] CandidateSettingsDelete Model)
		//{
		//	ServiceResponse<CandidateSettingsResponse> Response = await Service.DeleteAsync(Model);
		//	return new ServiceResponse<CandidateSettingsResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpGet]
		//[Route("api/candidatesettings")]
		//[Produces(typeof(ServiceResponse<CandidateSettingsResponse>))]
		//public async Task<ServiceResponse<CandidateSettingsResponse>> Get([FromQuery] CandidateSettingsSelect Model)
		//{
		//	ServiceResponse<CandidateSettingsResponse> Response = await Service.SelectAsync(Model);
		//	return new ServiceResponse<CandidateSettingsResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}

		//[HttpGet]
		//[Route("api/candidatesettingssingle")]
		//[Produces(typeof(ServiceResponse<CandidateSettingsResponse>))]
		//public async Task<ServiceResponse<CandidateSettingsResponse>> GetSingle([FromQuery] CandidateSettingsSelectSingle Model)
		//{
		//	ServiceResponse<CandidateSettingsResponse> Response = await Service.SelectSingleAsync(Model);
		//	return new ServiceResponse<CandidateSettingsResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}
	}
}