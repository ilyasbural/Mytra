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
		[Authorize]
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
	}
}