namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
    public class CandidateCertificateController : ControllerBase
    {
		readonly ICandidateCertificateService Service;
		public CandidateCertificateController(ICandidateCertificateService service) { Service = service; }

		[HttpPost]
		[Route("api/candidatecertificate")]
		[Produces(typeof(ServiceResponse<CandidateCertificate>))]
		public async Task<ServiceResponse<CandidateCertificate>> Create([FromBody] CandidateCertificateInsert Model)
		{
			DataService<CandidateCertificate> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateCertificate>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateCertificate>.FailureResponse("");
			return ServiceResponse<CandidateCertificate>.SuccessResponse(Response.Data, "");
		}

		//[HttpPut]
		//[Route("api/candidatecertificate")]
		//[Produces(typeof(ServiceResponse<CandidateCertificateResponse>))]
		//public async Task<ServiceResponse<CandidateCertificateResponse>> Update([FromBody] CandidateCertificateUpdate Model)
		//{
		//	ServiceResponse<CandidateCertificateResponse> Response = await Service.UpdateAsync(Model);
		//	return new ServiceResponse<CandidateCertificateResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpDelete]
		//[Route("api/candidatecertificate")]
		//[Produces(typeof(ServiceResponse<CandidateCertificateResponse>))]
		//public async Task<ServiceResponse<CandidateCertificateResponse>> Delete([FromBody] CandidateCertificateDelete Model)
		//{
		//	ServiceResponse<CandidateCertificateResponse> Response = await Service.DeleteAsync(Model);
		//	return new ServiceResponse<CandidateCertificateResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		[HttpGet]
		[Route("api/candidatecertificate")]
		[Produces(typeof(ServiceResponse<CandidateCertificate>))]
		public async Task<ServiceResponse<CandidateCertificate>> Get([FromQuery] CandidateCertificateSelect Model)
		{
			DataService<CandidateCertificate> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateCertificate>.SuccessResponse(Response.DataList, "candidatecertificates list added");
		}

		//[HttpGet]
		//[Route("api/candidatecertificatesingle")]
		//[Produces(typeof(ServiceResponse<CandidateCertificateResponse>))]
		//public async Task<ServiceResponse<CandidateCertificateResponse>> GetSingle([FromQuery] CandidateCertificateSelectSingle Model)
		//{
		//	ServiceResponse<CandidateCertificateResponse> Response = await Service.SelectSingleAsync(Model);
		//	return new ServiceResponse<CandidateCertificateResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}
	}
}