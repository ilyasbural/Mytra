namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
	public class SkillsController : ControllerBase
	{
		readonly ISkillsService Service;
		public SkillsController(ISkillsService service) { Service = service; }

		[HttpPost]
		[Route("api/skills")]
		[Produces(typeof(ServiceResponse<Skills>))]
		public async Task<ServiceResponse<Skills>> Create([FromBody] SkillsInsert Model)
		{
			DataService<Skills> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<Skills>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<Skills>.FailureResponse("");
			return ServiceResponse<Skills>.SuccessResponse(Response.Data, "");
		}

		//[HttpPut]
		//[Route("api/skills")]
		//[Produces(typeof(ServiceResponse<SkillsResponse>))]
		//public async Task<ServiceResponse<SkillsResponse>> Update([FromBody] SkillsUpdate Model)
		//{
		//	ServiceResponse<SkillsResponse> Response = await Service.UpdateAsync(Model);
		//	return new ServiceResponse<SkillsResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpDelete]
		//[Route("api/skills")]
		//[Produces(typeof(ServiceResponse<SkillsResponse>))]
		//public async Task<ServiceResponse<SkillsResponse>> Delete([FromBody] SkillsDelete Model)
		//{
		//	ServiceResponse<SkillsResponse> Response = await Service.DeleteAsync(Model);
		//	return new ServiceResponse<SkillsResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		[HttpGet]
		[Route("api/skills")]
		[Produces(typeof(ServiceResponse<Skills>))]
		public async Task<ServiceResponse<Skills>> Get([FromQuery] SkillsSelect Model)
		{
			DataService<Skills> Response = await Service.SelectAsync(Model);
			return ServiceResponse<Skills>.SuccessResponse(Response.DataList, "skills list added");
		}

		//[HttpGet]
		//[Route("api/skillssingle")]
		//[Produces(typeof(ServiceResponse<SkillsResponse>))]
		//public async Task<ServiceResponse<SkillsResponse>> GetSingle([FromQuery] SkillsSelectSingle Model)
		//{
		//	ServiceResponse<SkillsResponse> Response = await Service.SelectSingleAsync(Model);
		//	return new ServiceResponse<SkillsResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}
	}
}