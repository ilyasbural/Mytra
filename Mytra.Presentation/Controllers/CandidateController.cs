namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

    [ApiController]
    public class CandidateController : ControllerBase
    {
		//readonly ICandidateService Service;
		//public CandidateController(ICandidateService service) { Service = service; }

		//[HttpPost]
		//[Route("api/candidate")]
		//[Produces(typeof(ServiceResponse<CandidateResponse>))]
		//public async Task<ServiceResponse<CandidateResponse>> Create([FromBody] CandidateInsert Model)
		//{
		//	ServiceResponse<CandidateResponse> Response = await Service.InsertAsync(Model);
		//	return new ServiceResponse<CandidateResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpPut]
		//[Route("api/candidate")]
		//[Produces(typeof(ServiceResponse<CandidateResponse>))]
		//public async Task<ServiceResponse<CandidateResponse>> Update([FromBody] CandidateUpdate Model)
		//{
		//	ServiceResponse<CandidateResponse> Response = await Service.UpdateAsync(Model);
		//	return new ServiceResponse<CandidateResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpDelete]
		//[Route("api/candidate")]
		//[Produces(typeof(ServiceResponse<CandidateResponse>))]
		//public async Task<ServiceResponse<CandidateResponse>> Delete([FromBody] CandidateDelete Model)
		//{
		//	ServiceResponse<CandidateResponse> Response = await Service.DeleteAsync(Model);
		//	return new ServiceResponse<CandidateResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpGet]
		//[Route("api/candidate")]
		//[Produces(typeof(ServiceResponse<CandidateResponse>))]
		//public async Task<ServiceResponse<CandidateResponse>> Get([FromQuery] CandidateSelect Model)
		//{
		//	ServiceResponse<CandidateResponse> Response = await Service.SelectAsync(Model);
		//	return new ServiceResponse<CandidateResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}

		//[HttpGet]
		//[Route("api/candidatesingle")]
		//[Produces(typeof(ServiceResponse<CandidateResponse>))]
		//public async Task<ServiceResponse<CandidateResponse>> GetSingle([FromQuery] CandidateSelectSingle Model)
		//{
		//	ServiceResponse<CandidateResponse> Response = await Service.SelectSingleAsync(Model);
		//	return new ServiceResponse<CandidateResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}
	}
}