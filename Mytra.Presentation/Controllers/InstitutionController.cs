namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

    [ApiController]
    public class InstitutionController : ControllerBase
    {
		//readonly IInstitutionService Service;
		//public InstitutionController(IInstitutionService service) { Service = service; }

		//[HttpPost]
		//[Route("api/institution")]
		//[Produces(typeof(ServiceResponse<InstitutionResponse>))]
		//public async Task<ServiceResponse<InstitutionResponse>> Create([FromBody] InstitutionInsert Model)
		//{
		//	ServiceResponse<InstitutionResponse> Response = await Service.InsertAsync(Model);
		//	return new ServiceResponse<InstitutionResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpPut]
		//[Route("api/institution")]
		//[Produces(typeof(ServiceResponse<InstitutionResponse>))]
		//public async Task<ServiceResponse<InstitutionResponse>> Update([FromBody] InstitutionUpdate Model)
		//{
		//	ServiceResponse<InstitutionResponse> Response = await Service.UpdateAsync(Model);
		//	return new ServiceResponse<InstitutionResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpDelete]
		//[Route("api/institution")]
		//[Produces(typeof(ServiceResponse<InstitutionResponse>))]
		//public async Task<ServiceResponse<InstitutionResponse>> Delete([FromBody] InstitutionDelete Model)
		//{
		//	ServiceResponse<InstitutionResponse> Response = await Service.DeleteAsync(Model);
		//	return new ServiceResponse<InstitutionResponse>
		//	{
		//		Success = Response.Success,
		//		ResponseData = Response.ResponseData
		//	};
		//}

		//[HttpGet]
		//[Route("api/institution")]
		//[Produces(typeof(ServiceResponse<InstitutionResponse>))]
		//public async Task<ServiceResponse<InstitutionResponse>> Get([FromQuery] InstitutionSelect Model)
		//{
		//	ServiceResponse<InstitutionResponse> Response = await Service.SelectAsync(Model);
		//	return new ServiceResponse<InstitutionResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}

		//[HttpGet]
		//[Route("api/institutionsingle")]
		//[Produces(typeof(ServiceResponse<InstitutionResponse>))]
		//public async Task<ServiceResponse<InstitutionResponse>> GetSingle([FromQuery] InstitutionSelectSingle Model)
		//{
		//	ServiceResponse<InstitutionResponse> Response = await Service.SelectSingleAsync(Model);
		//	return new ServiceResponse<InstitutionResponse>
		//	{
		//		ResponseDataSource = Response.ResponseDataSource
		//	};
		//}
	}
}