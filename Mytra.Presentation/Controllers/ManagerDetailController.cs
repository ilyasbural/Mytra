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
		[Produces(typeof(ServiceResponse<ManagerDetail>))]
		public async Task<ServiceResponse<ManagerDetail>> Create([FromBody] ManagerDetailInsert Model)
		{
			DataService<ManagerDetail> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<ManagerDetail>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<ManagerDetail>.FailureResponse("");
			return ServiceResponse<ManagerDetail>.SuccessResponse(Response.Data, "");
		}

		[HttpPut]
		[Route("api/managerdetail")]
		[Produces(typeof(ServiceResponse<ManagerDetail>))]
		public async Task<ServiceResponse<ManagerDetail>> Update([FromBody] ManagerDetailUpdate Model)
		{
			DataService<ManagerDetail> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<ManagerDetail>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<ManagerDetail>.FailureResponse("");
			return ServiceResponse<ManagerDetail>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Route("api/managerdetail")]
		[Produces(typeof(ServiceResponse<ManagerDetail>))]
		public async Task<ServiceResponse<ManagerDetail>> Delete([FromBody] ManagerDetailDelete Model)
		{
			DataService<ManagerDetail> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<ManagerDetail>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<ManagerDetail>.FailureResponse("");
			return ServiceResponse<ManagerDetail>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/managerdetail")]
		[Produces(typeof(ServiceResponse<ManagerDetail>))]
		public async Task<ServiceResponse<ManagerDetail>> Get([FromQuery] ManagerDetailSelect Model)
		{
			DataService<ManagerDetail> Response = await Service.SelectAsync(Model);
			return ServiceResponse<ManagerDetail>.SuccessResponse(Response.DataList, "");
		}

		[HttpGet]
		[Route("api/managerdetailsingle")]
		[Produces(typeof(ServiceResponse<ManagerDetail>))]
		public async Task<ServiceResponse<ManagerDetail>> GetSingle([FromQuery] ManagerDetailSelectSingle Model)
		{
			DataService<ManagerDetail> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<ManagerDetail>.SuccessResponse(Response.Data, "");
		}
	}
}