namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
    public class CandidateLanguageController : ControllerBase
    {
		readonly IMapper Mapper;
		readonly ICandidateLanguageService Service;
		public CandidateLanguageController(IMapper mapper, ICandidateLanguageService service)
		{
			Mapper = mapper;
			Service = service;
		}

		[HttpPost]
		[Route("api/candidate")]
		[Produces(typeof(ServiceResponse<CandidateResponse>))]
		public async Task<ServiceResponse<CandidateResponse>> Create([FromBody] CandidateInsert Model)
		{
			DataService<Candidate> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateResponse>.FailureResponse("");
			return ServiceResponse<CandidateResponse>.SuccessResponse(Mapper.Map<List<CandidateResponse>>(Response.Data), "");
		}

		[HttpPost]
		[Authorize]
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
		[Authorize]
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
		[Authorize]
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
		[Authorize]
		[Route("api/candidatelanguage")]
		[Produces(typeof(ServiceResponse<CandidateLanguageResponse>))]
		public async Task<ServiceResponse<CandidateLanguageResponse>> Get([FromQuery] CandidateLanguageSelect Model)
		{
			DataService<CandidateLanguage> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateLanguageResponse>.SuccessResponse(Mapper.Map<List<CandidateLanguageResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidatelanguagesingle")]
		[Produces(typeof(ServiceResponse<CandidateLanguageResponse>))]
		public async Task<ServiceResponse<CandidateLanguageResponse>> GetSingle([FromQuery] CandidateLanguageSelectSingle Model)
		{
			DataService<CandidateLanguage> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CandidateLanguageResponse>.SuccessResponse(Mapper.Map<List<CandidateLanguageResponse>>(Response.Data), "");
		}
	}
}