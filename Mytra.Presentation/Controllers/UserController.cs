namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
	public class UserController : ControllerBase
	{
		readonly IUserService Service;
		public UserController(IUserService service) { Service = service; }

		[HttpPost]
		[Route("api/user")]
		[Produces(typeof(ServiceResponse<User>))]
		public async Task<ServiceResponse<User>> Create([FromBody] UserInsert Model)
		{
			DataService<User> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<User>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<User>.FailureResponse("");
			return ServiceResponse<User>.SuccessResponse(Response.Data, "");
		}

		//[HttpPut]
		//[Route("api/user")]
		//[Produces(typeof(ServiceResponse<UserResponse>))]
		//public async Task<ServiceResponse<UserResponse>> Update([FromBody] UserUpdate Model)
		//{
		//	ServiceResponse<UserResponse> Response = await Service.UpdateAsync(Model);
		//	return new ServiceResponse<UserResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpDelete]
		//[Route("api/user")]
		//[Produces(typeof(ServiceResponse<UserResponse>))]
		//public async Task<ServiceResponse<UserResponse>> Delete([FromBody] UserDelete Model)
		//{
		//	ServiceResponse<UserResponse> Response = await Service.DeleteAsync(Model);
		//	return new ServiceResponse<UserResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		[HttpGet]
		[Route("api/user")]
		[Produces(typeof(ServiceResponse<User>))]
		public async Task<ServiceResponse<User>> Get([FromQuery] UserSelect Model)
		{
			DataService<User> Response = await Service.SelectAsync(Model);
			return ServiceResponse<User>.SuccessResponse(Response.DataList, "users list added");
		}

		//[HttpGet]
		//[Route("api/usersingle")]
		//[Produces(typeof(ServiceResponse<UserResponse>))]
		//public async Task<ServiceResponse<UserResponse>> GetSingle([FromQuery] UserSelectSingle Model)
		//{
		//	ServiceResponse<UserResponse> Response = await Service.SelectSingleAsync(Model);
		//	return new ServiceResponse<UserResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}
	}
}