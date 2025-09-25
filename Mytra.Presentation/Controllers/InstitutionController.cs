namespace Mytra.Presentation.Controllers
{
	using Core;
	using Utilize;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
    public class InstitutionController : ControllerBase
    {
		readonly IMapper Mapper;
		readonly IInstitutionService Service;
		public InstitutionController(IMapper mapper, IInstitutionService service)
		{
			Mapper = mapper;
			Service = service;
		}

		[HttpPost]
		[Route("api/institution")]
		[Produces(typeof(ServiceResponse<InstitutionResponse>))]
		public async Task<ServiceResponse<InstitutionResponse>> Create([FromBody] InstitutionInsert Model)
		{
			DataService<Institution> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<InstitutionResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<InstitutionResponse>.FailureResponse("");
			return ServiceResponse<InstitutionResponse>.SuccessResponse(Mapper.Map<InstitutionResponse>(Response.Data), "");
		}

		[HttpPut]
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
		[Route("api/institution/{id}")]
		[Produces(typeof(ServiceResponse<Institution>))]
		public async Task<ServiceResponse<Institution>> Delete(Guid Id)
		{
			DataService<Institution> Response = await Service.DeleteAsync(Id);
			if (Response.Errors.Count > 0) return ServiceResponse<Institution>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<Institution>.FailureResponse("");
			return ServiceResponse<Institution>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/institution")]
		[Produces(typeof(ServiceResponse<InstitutionResponse>))]
		public async Task<ServiceResponse<InstitutionResponse>> Get([FromQuery] InstitutionSelect Model)
		{
			DataService<Institution> Response = await Service.SelectAsync(Model);
			return ServiceResponse<InstitutionResponse>.SuccessResponse(Mapper.Map<List<InstitutionResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Route("api/institutionsingle")]
		[Produces(typeof(ServiceResponse<InstitutionResponse>))]
		public async Task<ServiceResponse<InstitutionResponse>> GetSingle([FromQuery] InstitutionSelectSingle Model)
		{
			DataService<Institution> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<InstitutionResponse>.SuccessResponse(Mapper.Map<InstitutionResponse>(Response.Data), "");
		}
	}
}