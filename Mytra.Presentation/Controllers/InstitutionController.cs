namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

    [ApiController]
    public class InstitutionController : ControllerBase
    {
		readonly IInstitutionService Service;
		public InstitutionController(IInstitutionService service) { Service = service; }

		[HttpPost]
		[Authorize]
		[Route("api/institution")]
		[Produces(typeof(ServiceResponse<Institution>))]
		public async Task<ServiceResponse<Institution>> Create([FromBody] InstitutionInsert Model)
		{
			DataService<Institution> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<Institution>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<Institution>.FailureResponse("");
			return ServiceResponse<Institution>.SuccessResponse(Response.Data, "");
		}

		[HttpPut]
		[Authorize]
		[Route("api/institution")]
		[Produces(typeof(ServiceResponse<Institution>))]
		public async Task<ServiceResponse<Institution>> Update([FromBody] InstitutionUpdate Model)
		{
			DataService<Institution> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<Institution>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<Institution>.FailureResponse("");
			return ServiceResponse<Institution>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Authorize]
		[Route("api/institution")]
		[Produces(typeof(ServiceResponse<Institution>))]
		public async Task<ServiceResponse<Institution>> Delete([FromBody] InstitutionDelete Model)
		{
			DataService<Institution> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<Institution>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<Institution>.FailureResponse("");
			return ServiceResponse<Institution>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/institution")]
		[Produces(typeof(ServiceResponse<Institution>))]
		public async Task<ServiceResponse<Institution>> Get([FromQuery] InstitutionSelect Model)
		{
			DataService<Institution> Response = await Service.SelectAsync(Model);
			return ServiceResponse<Institution>.SuccessResponse(Response.DataList, "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/institutionsingle")]
		[Produces(typeof(ServiceResponse<Institution>))]
		public async Task<ServiceResponse<Institution>> GetSingle([FromQuery] InstitutionSelectSingle Model)
		{
			DataService<Institution> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<Institution>.SuccessResponse(Response.Data, "");
		}
	}
}