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
				Success = Response.Success,
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/managerdetail")]
		[Produces(typeof(ServiceResponse<ManagerDetailResponse>))]
		public async Task<ServiceResponse<ManagerDetailResponse>> Update([FromBody] ManagerDetailUpdate Model)
		{
			ServiceResponse<ManagerDetailResponse> Response = await Service.UpdateAsync(Model);
			return new ServiceResponse<ManagerDetailResponse>
			{
				Success = Response.Success,
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
				Success = Response.Success,
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Authorize]
		[Route("api/managerdetail")]
		[Produces(typeof(ServiceResponse<ManagerDetailResponse>))]
		public async Task<ServiceResponse<ManagerDetailResponse>> Get([FromQuery] ManagerDetailSelect Model)
		{
			ServiceResponse<ManagerDetailResponse> Response = await Service.SelectAsync(Model);
			return new ServiceResponse<ManagerDetailResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}

		[HttpGet]
		[Authorize]
		[Route("api/managerdetailsingle")]
		[Produces(typeof(ServiceResponse<ManagerDetailResponse>))]
		public async Task<ServiceResponse<ManagerDetailResponse>> GetSingle([FromQuery] ManagerDetailSelectSingle Model)
		{
			ServiceResponse<ManagerDetailResponse> Response = await Service.SelectSingleAsync(Model);
			return new ServiceResponse<ManagerDetailResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}
	}
}