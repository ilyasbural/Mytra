namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

	[ApiController]
    public class CandidateContactController : ControllerBase
    {
		readonly ICandidateContactService Service;
		public CandidateContactController(ICandidateContactService service) { Service = service; }

		//[HttpPost]
		//[Route("api/candidatecontact")]
		//[Produces(typeof(ServiceResponse<CandidateContactResponse>))]
		//public async Task<ServiceResponse<CandidateContactResponse>> Create([FromBody] CandidateContactInsert Model)
		//{
		//	ServiceResponse<CandidateContactResponse> Response = await Service.InsertAsync(Model);
		//	return new ServiceResponse<CandidateContactResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpPut]
		//[Route("api/candidatecontact")]
		//[Produces(typeof(ServiceResponse<CandidateContactResponse>))]
		//public async Task<ServiceResponse<CandidateContactResponse>> Update([FromBody] CandidateContactUpdate Model)
		//{
		//	ServiceResponse<CandidateContactResponse> Response = await Service.UpdateAsync(Model);
		//	return new ServiceResponse<CandidateContactResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpDelete]
		//[Route("api/candidatecontact")]
		//[Produces(typeof(ServiceResponse<CandidateContactResponse>))]
		//public async Task<ServiceResponse<CandidateContactResponse>> Delete([FromBody] CandidateContactDelete Model)
		//{
		//	ServiceResponse<CandidateContactResponse> Response = await Service.DeleteAsync(Model);
		//	return new ServiceResponse<CandidateContactResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		[HttpGet]
		[Route("api/candidatecontact")]
		[Produces(typeof(ServiceResponse<CandidateContact>))]
		public async Task<ServiceResponse<CandidateContact>> Get([FromQuery] CandidateContactSelect Model)
		{
			DataService<CandidateContact> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidateContact>.SuccessResponse(Response.DataList, "managerdetail list");
		}

		//[HttpGet]
		//[Route("api/candidatecontactsingle")]
		//[Produces(typeof(ServiceResponse<CandidateContactResponse>))]
		//public async Task<ServiceResponse<CandidateContactResponse>> GetSingle([FromQuery] CandidateContactSelectSingle Model)
		//{
		//	ServiceResponse<CandidateContactResponse> Response = await Service.SelectSingleAsync(Model);
		//	return new ServiceResponse<CandidateContactResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}
	}
}