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
		[Authorize]
		[Route("api/candidatelanguage")]
		[Produces(typeof(ServiceResponse<CandidateLanguageResponse>))]
		public async Task<ServiceResponse<CandidateLanguageResponse>> Create([FromBody] CandidateLanguageInsert Model)
		{
			ServiceResponse<CandidateLanguageResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<CandidateLanguageResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Authorize]
		[Route("api/candidatelanguage")]
		[Produces(typeof(ServiceResponse<CandidateLanguageResponse>))]
		public async Task<ServiceResponse<CandidateLanguageResponse>> Update([FromBody] CandidateLanguageUpdate Model)
		{
			ServiceResponse<CandidateLanguageResponse> Response = await Service.UpdateAsync(Model);
			return new ServiceResponse<CandidateLanguageResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Authorize]
		[Route("api/candidatelanguage")]
		[Produces(typeof(ServiceResponse<CandidateLanguageResponse>))]
		public async Task<ServiceResponse<CandidateLanguageResponse>> Delete([FromBody] CandidateLanguageDelete Model)
		{
			ServiceResponse<CandidateLanguageResponse> Response = await Service.DeleteAsync(Model);
			return new ServiceResponse<CandidateLanguageResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidatelanguage")]
		[Produces(typeof(ServiceResponse<CandidateLanguageResponse>))]
		public async Task<ServiceResponse<CandidateLanguageResponse>> Get([FromQuery] CandidateLanguageSelect Model)
		{
			ServiceResponse<CandidateLanguageResponse> Response = await Service.SelectAsync(Model);
			return new ServiceResponse<CandidateLanguageResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidatelanguagesingle")]
		[Produces(typeof(ServiceResponse<CandidateLanguageResponse>))]
		public async Task<ServiceResponse<CandidateLanguageResponse>> GetSingle([FromQuery] CandidateLanguageSelectSingle Model)
		{
			ServiceResponse<CandidateLanguageResponse> Response = await Service.SelectSingleAsync(Model);
			return new ServiceResponse<CandidateLanguageResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}
	}
}