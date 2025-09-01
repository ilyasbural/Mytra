namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

    [ApiController]
    public class CandidateLanguageController : ControllerBase
    {
		readonly ICandidateLanguageService Service;
		public CandidateLanguageController(ICandidateLanguageService service) { Service = service; }

		[HttpPost]
		[Route("api/candidatelanguage")]
		[Produces(typeof(ServiceResponse<CandidateLanguage>))]
		public async Task<ServiceResponse<CandidateLanguage>> Create([FromBody] CandidateLanguageInsert Model)
		{
			DataService<CandidateLanguage> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateLanguage>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateLanguage>.FailureResponse("");
			return ServiceResponse<CandidateLanguage>.SuccessResponse(Response.Data, "");
		}

		//[HttpPut]
		//[Route("api/candidatelanguage")]
		//[Produces(typeof(ServiceResponse<CandidateLanguageResponse>))]
		//public async Task<ServiceResponse<CandidateLanguageResponse>> Update([FromBody] CandidateLanguageUpdate Model)
		//{
		//	ServiceResponse<CandidateLanguageResponse> Response = await Service.UpdateAsync(Model);
		//	return new ServiceResponse<CandidateLanguageResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpDelete]
		//[Route("api/candidatelanguage")]
		//[Produces(typeof(ServiceResponse<CandidateLanguageResponse>))]
		//public async Task<ServiceResponse<CandidateLanguageResponse>> Delete([FromBody] CandidateLanguageDelete Model)
		//{
		//	ServiceResponse<CandidateLanguageResponse> Response = await Service.DeleteAsync(Model);
		//	return new ServiceResponse<CandidateLanguageResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		[HttpGet]
		[Route("api/candidatelanguage")]
		[Produces(typeof(ServiceResponse<CandidateLanguage>))]
		public async Task<ServiceResponse<CandidateLanguage>> Get([FromQuery] CandidateLanguageSelect Model)
		{
			DataService<CandidateLanguage> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateLanguage>.SuccessResponse(Response.DataList, "candidatelanguage list");
		}

		//[HttpGet]
		//[Route("api/candidatelanguagesingle")]
		//[Produces(typeof(ServiceResponse<CandidateLanguageResponse>))]
		//public async Task<ServiceResponse<CandidateLanguageResponse>> GetSingle([FromQuery] CandidateLanguageSelectSingle Model)
		//{
		//	ServiceResponse<CandidateLanguageResponse> Response = await Service.SelectSingleAsync(Model);
		//	return new ServiceResponse<CandidateLanguageResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}
	}
}