namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class CandidateCertificateController : ControllerBase
    {
		readonly ICandidateCertificateService Service;
		public CandidateCertificateController(ICandidateCertificateService service) { Service = service; }

		[HttpPost]
		[Route("api/candidatecertificate")]
		[Produces(typeof(ServiceResponse<CandidateCertificateResponse>))]
		public async Task<ServiceResponse<CandidateCertificateResponse>> Create([FromBody] CandidateCertificateInsert Model)
		{
			ServiceResponse<CandidateCertificateResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<CandidateCertificateResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/candidatecertificate")]
		[Produces(typeof(ServiceResponse<CandidateCertificateResponse>))]
		public async Task<ServiceResponse<CandidateCertificateResponse>> Update([FromBody] CandidateCertificateUpdate Model)
		{
			ServiceResponse<CandidateCertificateResponse> Response = await Service.UpdateAsync(Model);
			return new ServiceResponse<CandidateCertificateResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/candidatecertificate")]
		[Produces(typeof(ServiceResponse<CandidateCertificateResponse>))]
		public async Task<ServiceResponse<CandidateCertificateResponse>> Delete([FromBody] CandidateCertificateDelete Model)
		{
			ServiceResponse<CandidateCertificateResponse> Response = await Service.DeleteAsync(Model);
			return new ServiceResponse<CandidateCertificateResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/candidatecertificate")]
		[Produces(typeof(ServiceResponse<CandidateCertificateResponse>))]
		public async Task<ServiceResponse<CandidateCertificateResponse>> Get([FromQuery] CandidateCertificateSelect Model)
		{
			ServiceResponse<CandidateCertificateResponse> Response = await Service.SelectAsync(Model);
			return new ServiceResponse<CandidateCertificateResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}

		[HttpGet]
		[Route("api/candidatecertificatesingle")]
		[Produces(typeof(ServiceResponse<CandidateCertificateResponse>))]
		public async Task<ServiceResponse<CandidateCertificateResponse>> GetSingle([FromQuery] CandidateCertificateSelectSingle Model)
		{
			ServiceResponse<CandidateCertificateResponse> Response = await Service.SelectSingleAsync(Model);
			return new ServiceResponse<CandidateCertificateResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}
	}
}