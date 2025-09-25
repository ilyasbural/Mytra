namespace Mytra.Presentation.Controllers
{
	using Core;
	using Utilize;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
	public class UserController : ControllerBase
	{
		readonly IMapper Mapper;
		readonly IUserService Service;
		public UserController(IMapper mapper, IUserService service)
		{
			Mapper = mapper;
			Service = service;
		}

		[HttpPost]
		[Route("api/user")]
		[Produces(typeof(ServiceResponse<UserResponse>))]
		public async Task<ServiceResponse<UserResponse>> Create([FromBody] UserInsert Model)
		{
			DataService<User> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<UserResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<UserResponse>.FailureResponse("");
			return ServiceResponse<UserResponse>.SuccessResponse(Mapper.Map<UserResponse>(Response.Data), "");
		}

		[HttpPut]
		[Route("api/user")]
		[Produces(typeof(ServiceResponse<User>))]
		public async Task<ServiceResponse<User>> Update([FromBody] UserUpdate Model)
		{
			DataService<User> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<User>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<User>.FailureResponse("");
			return ServiceResponse<User>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Route("api/user/{id}")]
		[Produces(typeof(ServiceResponse<User>))]
		public async Task<ServiceResponse<User>> Delete(Guid Id)
		{
			DataService<User> Response = await Service.DeleteAsync(Id);
			if (Response.Errors.Count > 0) return ServiceResponse<User>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<User>.FailureResponse("");
			return ServiceResponse<User>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/user")]
		[Produces(typeof(ServiceResponse<UserResponse>))]
		public async Task<ServiceResponse<UserResponse>> Get([FromQuery] UserSelect Model)
		{
			DataService<User> Response = await Service.SelectAsync(Model);
			return ServiceResponse<UserResponse>.SuccessResponse(Mapper.Map<List<UserResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Route("api/usersingle")]
		[Produces(typeof(ServiceResponse<UserResponse>))]
		public async Task<ServiceResponse<UserResponse>> GetSingle([FromQuery] UserSelectSingle Model)
		{
			DataService<User> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<UserResponse>.SuccessResponse(Mapper.Map<UserResponse>(Response.Data), "");
		}
	}
}