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
	}
}