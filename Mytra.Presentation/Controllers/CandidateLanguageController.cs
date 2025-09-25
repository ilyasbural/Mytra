namespace Mytra.Presentation.Controllers
{
	using Core;
	using Utilize;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;

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
		[Route("api/candidatelanguage")]
		[Produces(typeof(ServiceResponse<CandidateLanguageResponse>))]
		public async Task<ServiceResponse<CandidateLanguageResponse>> Create([FromBody] CandidateLanguageInsert Model)
		{
			DataService<CandidateLanguage> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateLanguageResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateLanguageResponse>.FailureResponse("");
			return ServiceResponse<CandidateLanguageResponse>.SuccessResponse(Mapper.Map<CandidateLanguageResponse>(Response.Data), "");
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
		[Route("api/candidatelanguage/{id}")]
		[Produces(typeof(ServiceResponse<CandidateLanguage>))]
		public async Task<ServiceResponse<CandidateLanguage>> Delete(Guid Id)
		{
			DataService<CandidateLanguage> Response = await Service.DeleteAsync(Id);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateLanguage>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateLanguage>.FailureResponse("");
			return ServiceResponse<CandidateLanguage>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/candidatelanguage")]
		[Produces(typeof(ServiceResponse<CandidateLanguageResponse>))]
		public async Task<ServiceResponse<CandidateLanguageResponse>> Get([FromQuery] CandidateLanguageSelect Model)
		{
			DataService<CandidateLanguage> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateLanguageResponse>.SuccessResponse(Mapper.Map<List<CandidateLanguageResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Route("api/candidatelanguagesingle")]
		[Produces(typeof(ServiceResponse<CandidateLanguageResponse>))]
		public async Task<ServiceResponse<CandidateLanguageResponse>> GetSingle([FromQuery] CandidateLanguageSelectSingle Model)
		{
			DataService<CandidateLanguage> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CandidateLanguageResponse>.SuccessResponse(Mapper.Map<CandidateLanguageResponse>(Response.Data), "");
		}
	}
}