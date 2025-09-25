namespace Mytra.Presentation.Controllers
{
	using Core;
	using Utilize;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;

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
		[Route("api/userdetail")]
		[Produces(typeof(ServiceResponse<UserDetailResponse>))]
		public async Task<ServiceResponse<UserDetailResponse>> Create([FromBody] UserDetailInsert Model)
		{
			DataService<UserDetail> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<UserDetailResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<UserDetailResponse>.FailureResponse("");
			return ServiceResponse<UserDetailResponse>.SuccessResponse(Mapper.Map<UserDetailResponse>(Response.Data), "");
		}

		[HttpPut]
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
		[Route("api/userdetail/{Id}")]
		[Produces(typeof(ServiceResponse<UserDetail>))]
		public async Task<ServiceResponse<UserDetail>> Delete(Guid Id)
		{
			DataService<UserDetail> Response = await Service.DeleteAsync(Id);
			if (Response.Errors.Count > 0) return ServiceResponse<UserDetail>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<UserDetail>.FailureResponse("");
			return ServiceResponse<UserDetail>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/userdetail")]
		[Produces(typeof(ServiceResponse<UserDetailResponse>))]
		public async Task<ServiceResponse<UserDetailResponse>> Get([FromQuery] UserDetailSelect Model)
		{
			DataService<UserDetail> Response = await Service.SelectAsync(Model);
			return ServiceResponse<UserDetailResponse>.SuccessResponse(Mapper.Map<List<UserDetailResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Route("api/userdetailsingle")]
		[Produces(typeof(ServiceResponse<UserDetailResponse>))]
		public async Task<ServiceResponse<UserDetailResponse>> GetSingle([FromQuery] UserDetailSelectSingle Model)
		{
			DataService<UserDetail> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<UserDetailResponse>.SuccessResponse(Mapper.Map<UserDetailResponse>(Response.Data), "");
		}
	}
}