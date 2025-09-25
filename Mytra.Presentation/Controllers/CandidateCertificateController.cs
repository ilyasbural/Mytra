namespace Mytra.Presentation.Controllers
{
	using Core;
	using Utilize;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
    public class CandidateCertificateController : ControllerBase
    {
		readonly IMapper Mapper;
		readonly ICandidateCertificateService Service;
		public CandidateCertificateController(IMapper mapper, ICandidateCertificateService service)
		{
			Mapper = mapper;
			Service = service;
		}

		[HttpPost]
		[Route("api/candidatecertificate")]
		[Produces(typeof(ServiceResponse<CandidateCertificateResponse>))]
		public async Task<ServiceResponse<CandidateCertificateResponse>> Create([FromBody] CandidateCertificateInsert Model)
		{
			DataService<CandidateCertificate> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateCertificateResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateCertificateResponse>.FailureResponse("");
			return ServiceResponse<CandidateCertificateResponse>.SuccessResponse(Mapper.Map<CandidateCertificateResponse>(Response.Data), "");
		}

		[HttpPut]
		[Route("api/candidatecertificate")]
		[Produces(typeof(ServiceResponse<CandidateCertificate>))]
		public async Task<ServiceResponse<CandidateCertificate>> Update([FromBody] CandidateCertificateUpdate Model)
		{
			DataService<CandidateCertificate> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateCertificate>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateCertificate>.FailureResponse("");
			return ServiceResponse<CandidateCertificate>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Route("api/candidatecertificate/{id}")]
		[Produces(typeof(ServiceResponse<CandidateCertificate>))]
		public async Task<ServiceResponse<CandidateCertificate>> Delete(Guid Id)
		{
			DataService<CandidateCertificate> Response = await Service.DeleteAsync(Id);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateCertificate>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateCertificate>.FailureResponse("");
			return ServiceResponse<CandidateCertificate>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/candidatecertificate")]
		[Produces(typeof(ServiceResponse<CandidateCertificateResponse>))]
		public async Task<ServiceResponse<CandidateCertificateResponse>> Get([FromQuery] CandidateCertificateSelect Model)
		{
			DataService<CandidateCertificate> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateCertificateResponse>.SuccessResponse(Mapper.Map<List<CandidateCertificateResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Route("api/candidatecertificatesingle")]
		[Produces(typeof(ServiceResponse<CandidateCertificateResponse>))]
		public async Task<ServiceResponse<CandidateCertificateResponse>> GetSingle([FromQuery] CandidateCertificateSelectSingle Model)
		{
			DataService<CandidateCertificate> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CandidateCertificateResponse>.SuccessResponse(Mapper.Map<CandidateCertificateResponse>(Response.Data), "");
		}
	}
}