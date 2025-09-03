namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
    public class LanguageController : ControllerBase
    {
		readonly IMapper Mapper;
		readonly ILanguageService Service;
		public LanguageController(IMapper mapper, ILanguageService service)
		{
			Mapper = mapper;
			Service = service;
		}

		[HttpPost]
		[Authorize]
		[Route("api/language")]
		[Produces(typeof(ServiceResponse<Language>))]
		public async Task<ServiceResponse<Language>> Create([FromBody] LanguageInsert Model)
		{
			DataService<Language> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<Language>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<Language>.FailureResponse("");
			return ServiceResponse<Language>.SuccessResponse(Response.Data, "");
		}

		[HttpPut]
		[Authorize]
		[Route("api/language")]
		[Produces(typeof(ServiceResponse<Language>))]
		public async Task<ServiceResponse<Language>> Update([FromBody] LanguageUpdate Model)
		{
			DataService<Language> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<Language>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<Language>.FailureResponse("");
			return ServiceResponse<Language>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Authorize]
		[Route("api/language")]
		[Produces(typeof(ServiceResponse<Language>))]
		public async Task<ServiceResponse<Language>> Delete([FromBody] LanguageDelete Model)
		{
			DataService<Language> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<Language>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<Language>.FailureResponse("");
			return ServiceResponse<Language>.SuccessResponse(Response.Data, "");
		}







		[HttpGet]
		[Route("api/candidate")]
		[Produces(typeof(ServiceResponse<CandidateResponse>))]
		public async Task<ServiceResponse<CandidateResponse>> Get([FromQuery] CandidateSelect Model)
		{
			DataService<Candidate> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateResponse>.SuccessResponse(Mapper.Map<List<CandidateResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Route("api/candidatesingle")]
		[Produces(typeof(ServiceResponse<CandidateResponse>))]
		public async Task<ServiceResponse<CandidateResponse>> GetSingle([FromQuery] CandidateSelectSingle Model)
		{
			DataService<Candidate> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CandidateResponse>.SuccessResponse(Mapper.Map<List<CandidateResponse>>(Response.Data), "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/language")]
		[Produces(typeof(ServiceResponse<Language>))]
		public async Task<ServiceResponse<Language>> Get([FromQuery] LanguageSelect Model)
		{
			DataService<Language> Response = await Service.SelectAsync(Model);
			return ServiceResponse<Language>.SuccessResponse(Response.DataList, "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/languagesingle")]
		[Produces(typeof(ServiceResponse<Language>))]
		public async Task<ServiceResponse<Language>> GetSingle([FromQuery] LanguageSelectSingle Model)
		{
			DataService<Language> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<Language>.SuccessResponse(Response.Data, "");
		}
	}
}