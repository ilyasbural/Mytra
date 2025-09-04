namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
    public class CandidateContactController : ControllerBase
    {
		readonly IMapper Mapper;
		readonly ICandidateContactService Service;
		public CandidateContactController(IMapper mapper, ICandidateContactService service)
		{
			Mapper = mapper;
			Service = service;
		}

		[HttpPost]
		[Authorize]
		[Route("api/candidatecontact")]
		[Produces(typeof(ServiceResponse<CandidateContactResponse>))]
		public async Task<ServiceResponse<CandidateContactResponse>> Create([FromBody] CandidateContactInsert Model)
		{
			DataService<CandidateContact> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateContactResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateContactResponse>.FailureResponse("");
			return ServiceResponse<CandidateContactResponse>.SuccessResponse(Mapper.Map<CandidateContactResponse>(Response.Data), "");
		}

		[HttpPut]
		[Authorize]
		[Route("api/candidatecontact")]
		[Produces(typeof(ServiceResponse<CandidateContact>))]
		public async Task<ServiceResponse<CandidateContact>> Update([FromBody] CandidateContactUpdate Model)
		{
			DataService<CandidateContact> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateContact>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateContact>.FailureResponse("");
			return ServiceResponse<CandidateContact>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Authorize]
		[Route("api/candidatecontact")]
		[Produces(typeof(ServiceResponse<CandidateContact>))]
		public async Task<ServiceResponse<CandidateContact>> Delete([FromBody] CandidateContactDelete Model)
		{
			DataService<CandidateContact> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateContact>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateContact>.FailureResponse("");
			return ServiceResponse<CandidateContact>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidatecontact")]
		[Produces(typeof(ServiceResponse<CandidateContactResponse>))]
		public async Task<ServiceResponse<CandidateContactResponse>> Get([FromQuery] CandidateContactSelect Model)
		{
			DataService<CandidateContact> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateContactResponse>.SuccessResponse(Mapper.Map<List<CandidateContactResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidatecontactsingle")]
		[Produces(typeof(ServiceResponse<CandidateContactResponse>))]
		public async Task<ServiceResponse<CandidateContactResponse>> GetSingle([FromQuery] CandidateContactSelectSingle Model)
		{
			DataService<CandidateContact> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CandidateContactResponse>.SuccessResponse(Mapper.Map<List<CandidateContactResponse>>(Response.Data), "");
		}
	}
}