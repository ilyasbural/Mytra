namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
	public class UserDetailController : ControllerBase
	{
		readonly IMapper Mapper;
		readonly IUserDetailService Service;
		public UserDetailController(IMapper mapper, IUserDetailService service)
		{
			Mapper = mapper;
			Service = service;
		}

		[HttpPost]
		[Authorize]
		[Route("api/userdetail")]
		[Produces(typeof(ServiceResponse<UserDetail>))]
		public async Task<ServiceResponse<UserDetail>> Create([FromBody] UserDetailInsert Model)
		{
			DataService<UserDetail> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<UserDetail>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<UserDetail>.FailureResponse("");
			return ServiceResponse<UserDetail>.SuccessResponse(Response.Data, "");
		}

		[HttpPut]
		[Authorize]
		[Route("api/userdetail")]
		[Produces(typeof(ServiceResponse<UserDetail>))]
		public async Task<ServiceResponse<UserDetail>> Update([FromBody] UserDetailUpdate Model)
		{
			DataService<UserDetail> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<UserDetail>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<UserDetail>.FailureResponse("");
			return ServiceResponse<UserDetail>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Authorize]
		[Route("api/userdetail")]
		[Produces(typeof(ServiceResponse<UserDetail>))]
		public async Task<ServiceResponse<UserDetail>> Delete([FromBody] UserDetailDelete Model)
		{
			DataService<UserDetail> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<UserDetail>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<UserDetail>.FailureResponse("");
			return ServiceResponse<UserDetail>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/userdetail")]
		[Produces(typeof(ServiceResponse<UserDetailResponse>))]
		public async Task<ServiceResponse<UserDetailResponse>> Get([FromQuery] UserDetailSelect Model)
		{
			DataService<UserDetail> Response = await Service.SelectAsync(Model);
			return ServiceResponse<UserDetailResponse>.SuccessResponse(Mapper.Map<List<UserDetailResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/userdetailsingle")]
		[Produces(typeof(ServiceResponse<UserDetailResponse>))]
		public async Task<ServiceResponse<UserDetailResponse>> GetSingle([FromQuery] UserDetailSelectSingle Model)
		{
			DataService<UserDetail> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<UserDetailResponse>.SuccessResponse(Mapper.Map<List<UserDetailResponse>>(Response.Data), "");
		}
	}
}