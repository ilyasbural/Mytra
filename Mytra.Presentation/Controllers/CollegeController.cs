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
		[Produces(typeof(ServiceResponse<College>))]
		public async Task<ServiceResponse<College>> Create([FromBody] CollegeInsert Model)
		{
			DataService<College> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<College>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<College>.FailureResponse("");
			return ServiceResponse<College>.SuccessResponse(Response.Data, "");
		}

		//[HttpPut]
		//[Route("api/college")]
		//[Produces(typeof(ServiceResponse<CollegeResponse>))]
		//public async Task<ServiceResponse<CollegeResponse>> Update([FromBody] CollegeUpdate Model)
		//{
		//	ServiceResponse<CollegeResponse> Response = await Service.UpdateAsync(Model);
		//	return new ServiceResponse<CollegeResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpDelete]
		//[Route("api/college")]
		//[Produces(typeof(ServiceResponse<CollegeResponse>))]
		//public async Task<ServiceResponse<CollegeResponse>> Delete([FromBody] CollegeDelete Model)
		//{
		//	ServiceResponse<CollegeResponse> Response = await Service.DeleteAsync(Model);
		//	return new ServiceResponse<CollegeResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		[HttpGet]
		[Route("api/college")]
		[Produces(typeof(ServiceResponse<College>))]
		public async Task<ServiceResponse<College>> Get([FromQuery] CollegeSelect Model)
		{
			DataService<College> Response = await Service.SelectAsync(Model);
			return ServiceResponse<College>.SuccessResponse(Response.DataList, "college list");
		}

		//[HttpGet]
		//[Route("api/collegesingle")]
		//[Produces(typeof(ServiceResponse<CollegeResponse>))]
		//public async Task<ServiceResponse<CollegeResponse>> GetSingle([FromQuery] CollegeSelectSingle Model)
		//{
		//	ServiceResponse<CollegeResponse> Response = await Service.SelectSingleAsync(Model);
		//	return new ServiceResponse<CollegeResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}
	}
}