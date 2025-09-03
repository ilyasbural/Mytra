namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

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
		[Authorize]
		[Route("api/candidatecertificate")]
		[Produces(typeof(ServiceResponse<CandidateCertificateResponse>))]
		public async Task<ServiceResponse<CandidateCertificateResponse>> Create([FromBody] CandidateCertificateInsert Model)
		{
			DataService<CandidateCertificate> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateCertificateResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateCertificateResponse>.FailureResponse("");
			return ServiceResponse<CandidateCertificateResponse>.SuccessResponse(Mapper.Map<List<CandidateCertificateResponse>>(Response.Data), "");
		}

		[HttpPut]
		[Authorize]
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
		[Authorize]
		[Route("api/candidatecertificate")]
		[Produces(typeof(ServiceResponse<CandidateCertificate>))]
		public async Task<ServiceResponse<CandidateCertificate>> Delete([FromBody] CandidateCertificateDelete Model)
		{
			DataService<CandidateCertificate> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateCertificate>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateCertificate>.FailureResponse("");
			return ServiceResponse<CandidateCertificate>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidatecertificate")]
		[Produces(typeof(ServiceResponse<CandidateCertificateResponse>))]
		public async Task<ServiceResponse<CandidateCertificateResponse>> Get([FromQuery] CandidateCertificateSelect Model)
		{
			DataService<CandidateCertificate> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateCertificateResponse>.SuccessResponse(Mapper.Map<List<CandidateCertificateResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidatecertificatesingle")]
		[Produces(typeof(ServiceResponse<CandidateCertificateResponse>))]
		public async Task<ServiceResponse<CandidateCertificateResponse>> GetSingle([FromQuery] CandidateCertificateSelectSingle Model)
		{
			DataService<CandidateCertificate> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CandidateCertificateResponse>.SuccessResponse(Mapper.Map<List<CandidateCertificateResponse>>(Response.Data), "");
		}
	}
}