namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
	public class UserDetailController : ControllerBase
	{
		readonly IUserDetailService Service;
		public UserDetailController(IUserDetailService service) { Service = service; }

		[HttpPost]
		[Authorize]
		[Route("api/userdetail")]
		[Produces(typeof(ServiceResponse<UserDetailResponse>))]
		public async Task<ServiceResponse<UserDetailResponse>> Create([FromBody] UserDetailInsert Model)
		{
			ServiceResponse<UserDetailResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<UserDetailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}
	}
}