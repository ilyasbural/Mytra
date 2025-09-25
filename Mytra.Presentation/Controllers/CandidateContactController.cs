namespace Mytra.Presentation.Controllers
{
	using Core;
	using Utilize;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;

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
		[Route("api/candidatecontact/{id}")]
		[Produces(typeof(ServiceResponse<CandidateContact>))]
		public async Task<ServiceResponse<CandidateContact>> Delete(Guid Id)
		{
			DataService<CandidateContact> Response = await Service.DeleteAsync(Id);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateContact>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateContact>.FailureResponse("");
			return ServiceResponse<CandidateContact>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/candidatecontact")]
		[Produces(typeof(ServiceResponse<CandidateContactResponse>))]
		public async Task<ServiceResponse<CandidateContactResponse>> Get([FromQuery] CandidateContactSelect Model)
		{
			DataService<CandidateContact> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateContactResponse>.SuccessResponse(Mapper.Map<List<CandidateContactResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Route("api/candidatecontactsingle")]
		[Produces(typeof(ServiceResponse<CandidateContactResponse>))]
		public async Task<ServiceResponse<CandidateContactResponse>> GetSingle([FromQuery] CandidateContactSelectSingle Model)
		{
			DataService<CandidateContact> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CandidateContactResponse>.SuccessResponse(Mapper.Map<CandidateContactResponse>(Response.Data), "");
		}
	}
}