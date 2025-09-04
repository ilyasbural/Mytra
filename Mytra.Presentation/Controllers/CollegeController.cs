namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
    public class CollegeController : ControllerBase
    {
		readonly IMapper Mapper;
		readonly ICollegeService Service;
		public CollegeController(IMapper mapper, ICollegeService service)
		{
			Mapper = mapper;
			Service = service;
		}

		[HttpPost]
		[Authorize]
		[Route("api/college")]
		[Produces(typeof(ServiceResponse<CollegeResponse>))]
		public async Task<ServiceResponse<CollegeResponse>> Create([FromBody] CollegeInsert Model)
		{
			DataService<College> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CollegeResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CollegeResponse>.FailureResponse("");
			return ServiceResponse<CollegeResponse>.SuccessResponse(Mapper.Map<List<CollegeResponse>>(Response.Data), "");
		}

		[HttpPut]
		[Authorize]
		[Route("api/college")]
		[Produces(typeof(ServiceResponse<College>))]
		public async Task<ServiceResponse<College>> Update([FromBody] CollegeUpdate Model)
		{
			DataService<College> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<College>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<College>.FailureResponse("");
			return ServiceResponse<College>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Authorize]
		[Route("api/college")]
		[Produces(typeof(ServiceResponse<College>))]
		public async Task<ServiceResponse<College>> Delete([FromBody] CollegeDelete Model)
		{
			DataService<College> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<College>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<College>.FailureResponse("");
			return ServiceResponse<College>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/college")]
		[Produces(typeof(ServiceResponse<CollegeResponse>))]
		public async Task<ServiceResponse<CollegeResponse>> Get([FromQuery] CollegeSelect Model)
		{
			DataService<College> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CollegeResponse>.SuccessResponse(Mapper.Map<List<CollegeResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/collegesingle")]
		[Produces(typeof(ServiceResponse<CollegeResponse>))]
		public async Task<ServiceResponse<CollegeResponse>> GetSingle([FromQuery] CollegeSelectSingle Model)
		{
			DataService<College> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CollegeResponse>.SuccessResponse(Mapper.Map<List<CollegeResponse>>(Response.Data), "");
		}
	}
}