namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
    public class CollegeController : ControllerBase
    {
		readonly ICollegeService Service;
		public CollegeController(ICollegeService service) { Service = service; }

		[HttpPost]
		[Authorize]
		[Route("api/college")]
		[Produces(typeof(ServiceResponse<CollegeResponse>))]
		public async Task<ServiceResponse<CollegeResponse>> Create([FromBody] CollegeInsert Model)
		{
			ServiceResponse<CollegeResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<CollegeResponse>
			{
				ResponseData = Response.ResponseData
			};
		}
	}
}