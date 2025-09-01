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

		[HttpPut]
		[Route("api/candidatelanguage")]
		[Produces(typeof(ServiceResponse<CandidateLanguage>))]
		public async Task<ServiceResponse<CandidateLanguage>> Update([FromBody] CandidateLanguageUpdate Model)
		{
			DataService<CandidateLanguage> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateLanguage>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateLanguage>.FailureResponse("");
			return ServiceResponse<CandidateLanguage>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Route("api/candidatelanguage")]
		[Produces(typeof(ServiceResponse<CandidateLanguage>))]
		public async Task<ServiceResponse<CandidateLanguage>> Delete([FromBody] CandidateLanguageDelete Model)
		{
			DataService<CandidateLanguage> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateLanguage>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateLanguage>.FailureResponse("");
			return ServiceResponse<CandidateLanguage>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/candidatelanguage")]
		[Produces(typeof(ServiceResponse<CandidateLanguage>))]
		public async Task<ServiceResponse<CandidateLanguage>> Get([FromQuery] CandidateLanguageSelect Model)
		{
			DataService<CandidateLanguage> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateLanguage>.SuccessResponse(Response.DataList, "");
		}

		[HttpGet]
		[Route("api/candidatelanguagesingle")]
		[Produces(typeof(ServiceResponse<CandidateLanguage>))]
		public async Task<ServiceResponse<CandidateLanguage>> GetSingle([FromQuery] CandidateLanguageSelectSingle Model)
		{
			DataService<CandidateLanguage> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CandidateLanguage>.SuccessResponse(Response.Data, "");
		}
	}
}