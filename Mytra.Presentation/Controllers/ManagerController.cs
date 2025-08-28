namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
	public class ManagerController : ControllerBase
	{
		readonly IManagerService Service;
		public ManagerController(IManagerService service) { Service = service; }

		[HttpPost]
		[Authorize]
		[Route("api/manager")]
		[Produces(typeof(ServiceResponse<ManagerResponse>))]
		public async Task<ServiceResponse<ManagerResponse>> Create([FromBody] ManagerInsert Model)
		{
			ServiceResponse<ManagerResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<ManagerResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Authorize]   
		[Route("api/manager")]
		[Produces(typeof(ServiceResponse<ManagerResponse>))]
		public async Task<ServiceResponse<ManagerResponse>> Update([FromBody] ManagerUpdate Model)
		{
			ServiceResponse<ManagerResponse> Response = await Service.UpdateAsync(Model);
			return new ServiceResponse<ManagerResponse>
			{
				ResponseData = Response.ResponseData
			};
		}
	}
}