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

		[HttpPut]
		[Authorize]
		[Route("api/userdetail")]
		[Produces(typeof(ServiceResponse<UserDetailResponse>))]
		public async Task<ServiceResponse<UserDetailResponse>> Update([FromBody] UserDetailUpdate Model)
		{
			ServiceResponse<UserDetailResponse> Response = await Service.UpdateAsync(Model);
			return new ServiceResponse<UserDetailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Authorize]
		[Route("api/userdetail")]
		[Produces(typeof(ServiceResponse<UserDetailResponse>))]
		public async Task<ServiceResponse<UserDetailResponse>> Delete([FromBody] UserDetailDelete Model)
		{
			ServiceResponse<UserDetailResponse> Response = await Service.DeleteAsync(Model);
			return new ServiceResponse<UserDetailResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Authorize]
		[Route("api/userdetail")]
		[Produces(typeof(ServiceResponse<UserDetailResponse>))]
		public async Task<ServiceResponse<UserDetailResponse>> Get([FromQuery] UserDetailSelect Model)
		{
			ServiceResponse<UserDetailResponse> Response = await Service.SelectAsync(Model);
			return new ServiceResponse<UserDetailResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}

		[HttpGet]
		[Authorize]
		[Route("api/userdetailsingle")]
		[Produces(typeof(ServiceResponse<UserDetailResponse>))]
		public async Task<ServiceResponse<UserDetailResponse>> GetSingle([FromQuery] UserDetailSelectSingle Model)
		{
			ServiceResponse<UserDetailResponse> Response = await Service.SelectSingleAsync(Model);
			return new ServiceResponse<UserDetailResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}
	}
}