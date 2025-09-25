namespace Mytra.Presentation.Controllers
{
	using Core;
	using Utilize;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;

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
		[Route("api/language")]
		[Produces(typeof(ServiceResponse<LanguageResponse>))]
		public async Task<ServiceResponse<LanguageResponse>> Create([FromBody] LanguageInsert Model)
		{
			DataService<Language> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<LanguageResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<LanguageResponse>.FailureResponse("");
			return ServiceResponse<LanguageResponse>.SuccessResponse(Mapper.Map<LanguageResponse>(Response.Data), "");
		}

		[HttpPut]
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
		[Route("api/language/{id}")]
		[Produces(typeof(ServiceResponse<Language>))]
		public async Task<ServiceResponse<Language>> Delete(Guid Id)
		{
			DataService<Language> Response = await Service.DeleteAsync(Id);
			if (Response.Errors.Count > 0) return ServiceResponse<Language>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<Language>.FailureResponse("");
			return ServiceResponse<Language>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/language")]
		[Produces(typeof(ServiceResponse<LanguageResponse>))]
		public async Task<ServiceResponse<LanguageResponse>> Get([FromQuery] LanguageSelect Model)
		{
			DataService<Language> Response = await Service.SelectAsync(Model);
			return ServiceResponse<LanguageResponse>.SuccessResponse(Mapper.Map<List<LanguageResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Route("api/languagesingle")]
		[Produces(typeof(ServiceResponse<LanguageResponse>))]
		public async Task<ServiceResponse<LanguageResponse>> GetSingle([FromQuery] LanguageSelectSingle Model)
		{
			DataService<Language> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<LanguageResponse>.SuccessResponse(Mapper.Map<LanguageResponse>(Response.Data), "");
		}
	}
}