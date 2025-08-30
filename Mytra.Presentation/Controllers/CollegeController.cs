namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
    public class CollegeController : ControllerBase
    {
		readonly ICollegeService Service;
		public CollegeController(ICollegeService service) { Service = service; }

		[HttpPost]
		[Route("api/college")]
		[Produces(typeof(ServiceResponse<CollegeResponse>))]
		public async Task<ServiceResponse<CollegeResponse>> Create([FromBody] CollegeInsert Model)
		{
			ServiceResponse<CollegeResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<CollegeResponse>
			{
				Success = Response.Success,
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Authorize]
		[Route("api/college")]
		[Produces(typeof(ServiceResponse<CollegeResponse>))]
		public async Task<ServiceResponse<CollegeResponse>> Update([FromBody] CollegeUpdate Model)
		{
			ServiceResponse<CollegeResponse> Response = await Service.UpdateAsync(Model);
			return new ServiceResponse<CollegeResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Authorize]
		[Route("api/college")]
		[Produces(typeof(ServiceResponse<CollegeResponse>))]
		public async Task<ServiceResponse<CollegeResponse>> Delete([FromBody] CollegeDelete Model)
		{
			ServiceResponse<CollegeResponse> Response = await Service.DeleteAsync(Model);
			return new ServiceResponse<CollegeResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Authorize]
		[Route("api/college")]
		[Produces(typeof(ServiceResponse<CollegeResponse>))]
		public async Task<ServiceResponse<CollegeResponse>> Get([FromQuery] CollegeSelect Model)
		{
			ServiceResponse<CollegeResponse> Response = await Service.SelectAsync(Model);
			return new ServiceResponse<CollegeResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}

		[HttpGet]
		[Authorize]
		[Route("api/collegesingle")]
		[Produces(typeof(ServiceResponse<CollegeResponse>))]
		public async Task<ServiceResponse<CollegeResponse>> GetSingle([FromQuery] CollegeSelectSingle Model)
		{
			ServiceResponse<CollegeResponse> Response = await Service.SelectSingleAsync(Model);
			return new ServiceResponse<CollegeResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}
	}
}