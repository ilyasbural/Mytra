namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
	public class ManagerDetailController : ControllerBase
	{
		readonly IManagerDetailService Service;
		public ManagerDetailController(IManagerDetailService service) { Service = service; }

		[HttpPost]
		[Route("api/managerdetail")]
		[Produces(typeof(ServiceResponse<ManagerDetailResponse>))]
		public async Task<ServiceResponse<ManagerDetailResponse>> Create([FromBody] ManagerDetailInsert Model)
		{
			ServiceResponse<ManagerDetailResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<ManagerDetailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}
	}
}