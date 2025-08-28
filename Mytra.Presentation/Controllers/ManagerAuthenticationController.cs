namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
	public class ManagerAuthenticationController : ControllerBase
	{
		readonly IManagerAuthenticationService Service;
		public ManagerAuthenticationController(IManagerAuthenticationService service) { Service = service; }

		[HttpPost]
		[Route("api/managerauthentication")]
		[Produces(typeof(ServiceResponse<ManagerAuthenticationResponse>))]
		public async Task<ServiceResponse<ManagerAuthenticationResponse>> Create([FromBody] ManagerAuthenticationInsert Model)
		{
			ServiceResponse<ManagerAuthenticationResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<ManagerAuthenticationResponse>
			{
				ResponseData = Response.ResponseData
			};
		}
	}
}