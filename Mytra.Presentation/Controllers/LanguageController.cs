namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

    [ApiController]
    public class LanguageController : ControllerBase
    {
		readonly ILanguageService Service;
		public LanguageController(ILanguageService service) { Service = service; }

		[HttpPost]
		[Route("api/language")]
		[Produces(typeof(ServiceResponse<LanguageResponse>))]
		public async Task<ServiceResponse<LanguageResponse>> Create([FromBody] LanguageInsert Model)
		{
			ServiceResponse<LanguageResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<LanguageResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Authorize]
		[Route("api/language")]
		[Produces(typeof(ServiceResponse<LanguageResponse>))]
		public async Task<ServiceResponse<LanguageResponse>> Update([FromBody] LanguageUpdate Model)
		{
			ServiceResponse<LanguageResponse> Response = await Service.UpdateAsync(Model);
			return new ServiceResponse<LanguageResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Authorize]
		[Route("api/language")]
		[Produces(typeof(ServiceResponse<LanguageResponse>))]
		public async Task<ServiceResponse<LanguageResponse>> Delete([FromBody] LanguageDelete Model)
		{
			ServiceResponse<LanguageResponse> Response = await Service.DeleteAsync(Model);
			return new ServiceResponse<LanguageResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Authorize]
		[Route("api/language")]
		[Produces(typeof(ServiceResponse<LanguageResponse>))]
		public async Task<ServiceResponse<LanguageResponse>> Get([FromQuery] LanguageSelect Model)
		{
			ServiceResponse<LanguageResponse> Response = await Service.SelectAsync(Model);
			return new ServiceResponse<LanguageResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}

		[HttpGet]
		[Authorize]
		[Route("api/languagesingle")]
		[Produces(typeof(ServiceResponse<LanguageResponse>))]
		public async Task<ServiceResponse<LanguageResponse>> GetSingle([FromQuery] LanguageSelectSingle Model)
		{
			ServiceResponse<LanguageResponse> Response = await Service.SelectSingleAsync(Model);
			return new ServiceResponse<LanguageResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}
	}
}