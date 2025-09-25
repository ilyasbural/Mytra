namespace Mytra.Presentation.Controllers
{
	using Core;
	using Utilize;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;

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
		[Route("api/college")]
		[Produces(typeof(ServiceResponse<CollegeResponse>))]
		public async Task<ServiceResponse<CollegeResponse>> Create([FromBody] CollegeInsert Model)
		{
			DataService<College> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CollegeResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CollegeResponse>.FailureResponse("");
			return ServiceResponse<CollegeResponse>.SuccessResponse(Mapper.Map<CollegeResponse>(Response.Data), "");
		}

		[HttpPut]
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
		[Route("api/college/{id}")]
		[Produces(typeof(ServiceResponse<College>))]
		public async Task<ServiceResponse<College>> Delete(Guid Id)
		{
			DataService<College> Response = await Service.DeleteAsync(Id);
			if (Response.Errors.Count > 0) return ServiceResponse<College>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<College>.FailureResponse("");
			return ServiceResponse<College>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/college")]
		[Produces(typeof(ServiceResponse<CollegeResponse>))]
		public async Task<ServiceResponse<CollegeResponse>> Get([FromQuery] CollegeSelect Model)
		{
			DataService<College> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CollegeResponse>.SuccessResponse(Mapper.Map<List<CollegeResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Route("api/collegesingle")]
		[Produces(typeof(ServiceResponse<CollegeResponse>))]
		public async Task<ServiceResponse<CollegeResponse>> GetSingle([FromQuery] CollegeSelectSingle Model)
		{
			DataService<College> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CollegeResponse>.SuccessResponse(Mapper.Map<CollegeResponse>(Response.Data), "");
		}
	}
}