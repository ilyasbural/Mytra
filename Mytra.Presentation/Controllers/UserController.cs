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
		[Authorize]
		[Route("api/user")]
		[Produces(typeof(ServiceResponse<UserResponse>))]
		public async Task<ServiceResponse<UserResponse>> Create([FromBody] UserInsert Model)
		{
			ServiceResponse<UserResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<UserResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Authorize]
		[Route("api/user")]
		[Produces(typeof(ServiceResponse<UserResponse>))]
		public async Task<ServiceResponse<UserResponse>> Update([FromBody] UserUpdate Model)
		{
			ServiceResponse<UserResponse> Response = await Service.UpdateAsync(Model);
			return new ServiceResponse<UserResponse>
			{
				ResponseData = Response.ResponseData
			};
		}
	}
}