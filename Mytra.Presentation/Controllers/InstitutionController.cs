namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

    [ApiController]
    public class InstitutionController : ControllerBase
    {
		readonly IInstitutionService Service;
		public InstitutionController(IInstitutionService service) { Service = service; }

		[HttpPost]
		[Authorize]
		[Route("api/institution")]
		[Produces(typeof(ServiceResponse<InstitutionResponse>))]
		public async Task<ServiceResponse<InstitutionResponse>> Create([FromBody] InstitutionInsert Model)
		{
			ServiceResponse<InstitutionResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<InstitutionResponse>
			{
				ResponseData = Response.ResponseData
			};
		}
	}
}