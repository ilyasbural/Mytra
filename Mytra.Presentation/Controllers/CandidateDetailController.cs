namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
    public class CandidateDetailController : ControllerBase
    {
		private readonly ICandidateDetailService Service;
		public CandidateDetailController(ICandidateDetailService service) { Service = service; }

		[HttpPost]
		[Route("api/candidatedetail")]
		[Produces(typeof(ServiceResponse<CandidateDetail>))]
		public async Task<ServiceResponse<CandidateDetail>> Create([FromBody] CandidateDetailInsert Model)
		{
			DataService<CandidateDetail> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateDetail>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateDetail>.FailureResponse("");
			return ServiceResponse<CandidateDetail>.SuccessResponse(Response.Data, "");
		}

		//[HttpPut]
		//[Route("api/candidatedetail")]
		//[Produces(typeof(ServiceResponse<CandidateDetailResponse>))]
		//public async Task<ServiceResponse<CandidateDetailResponse>> Update([FromBody] CandidateDetailUpdate Model)
		//{
		//	ServiceResponse<CandidateDetailResponse> Response = await Service.UpdateAsync(Model);
		//	return new ServiceResponse<CandidateDetailResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpDelete]
		//[Route("api/candidatedetail")]
		//[Produces(typeof(ServiceResponse<CandidateDetailResponse>))]
		//public async Task<ServiceResponse<CandidateDetailResponse>> Delete([FromBody] CandidateDetailDelete Model)
		//{
		//	ServiceResponse<CandidateDetailResponse> Response = await Service.DeleteAsync(Model);
		//	return new ServiceResponse<CandidateDetailResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		[HttpGet]
		[Route("api/candidatedetail")]
		[Produces(typeof(ServiceResponse<CandidateDetail>))]
		public async Task<ServiceResponse<CandidateDetail>> Get([FromQuery] CandidateDetailSelect Model)
		{
			DataService<CandidateDetail> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateDetail>.SuccessResponse(Response.DataList, "candidatedetail list");
		}

		//[HttpGet]
		//[Route("api/candidatedetailsingle")]
		//[Produces(typeof(ServiceResponse<CandidateDetailResponse>))]
		//public async Task<ServiceResponse<CandidateDetailResponse>> GetSingle([FromQuery] CandidateDetailSelectSingle Model)
		//{
		//	ServiceResponse<CandidateDetailResponse> Response = await Service.SelectSingleAsync(Model);
		//	return new ServiceResponse<CandidateDetailResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}
	}
}