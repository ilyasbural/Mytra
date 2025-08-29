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
		[Authorize]
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

		[HttpPut]
		[Authorize]
		[Route("api/managerdetail")]
		[Produces(typeof(ServiceResponse<ManagerDetailResponse>))]
		public async Task<ServiceResponse<ManagerDetailResponse>> Update([FromBody] ManagerDetailUpdate Model)
		{
			ServiceResponse<ManagerDetailResponse> Response = await Service.UpdateAsync(Model);
			return new ServiceResponse<ManagerDetailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/managerdetail")]
		[Produces(typeof(ServiceResponse<ManagerDetailResponse>))]
		public async Task<ServiceResponse<ManagerDetailResponse>> Delete([FromBody] ManagerDetailDelete Model)
		{
			ServiceResponse<ManagerDetailResponse> Response = await Service.DeleteAsync(Model);
			return new ServiceResponse<ManagerDetailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}
	}
}