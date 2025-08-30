namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

    [ApiController]
    public class CandidateReferanceController : ControllerBase
    {
		readonly ICandidateReferanceService Service;
		public CandidateReferanceController(ICandidateReferanceService service) { Service = service; }

		[HttpPost]
		[Route("api/candidatereferance")]
		[Produces(typeof(ServiceResponse<CandidateReferanceResponse>))]
		public async Task<ServiceResponse<CandidateReferanceResponse>> Create([FromBody] CandidateReferanceInsert Model)
		{
			ServiceResponse<CandidateReferanceResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<CandidateReferanceResponse>
			{
				Success = Response.Success,
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/candidatereferance")]
		[Produces(typeof(ServiceResponse<CandidateReferanceResponse>))]
		public async Task<ServiceResponse<CandidateReferanceResponse>> Update([FromBody] CandidateReferanceUpdate Model)
		{
			ServiceResponse<CandidateReferanceResponse> Response = await Service.UpdateAsync(Model);
			return new ServiceResponse<CandidateReferanceResponse>
			{
				Success = Response.Success,
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/candidatereferance")]
		[Produces(typeof(ServiceResponse<CandidateReferanceResponse>))]
		public async Task<ServiceResponse<CandidateReferanceResponse>> Delete([FromBody] CandidateReferanceDelete Model)
		{
			ServiceResponse<CandidateReferanceResponse> Response = await Service.DeleteAsync(Model);
			return new ServiceResponse<CandidateReferanceResponse>
			{
				Success = Response.Success,
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/candidatereferance")]
		[Produces(typeof(ServiceResponse<CandidateReferanceResponse>))]
		public async Task<ServiceResponse<CandidateReferanceResponse>> Get([FromQuery] CandidateReferanceSelect Model)
		{
			ServiceResponse<CandidateReferanceResponse> Response = await Service.SelectAsync(Model);
			return new ServiceResponse<CandidateReferanceResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}

		[HttpGet]
		[Route("api/candidatereferancesingle")]
		[Produces(typeof(ServiceResponse<CandidateReferanceResponse>))]
		public async Task<ServiceResponse<CandidateReferanceResponse>> GetSingle([FromQuery] CandidateReferanceSelectSingle Model)
		{
			ServiceResponse<CandidateReferanceResponse> Response = await Service.SelectSingleAsync(Model);
			return new ServiceResponse<CandidateReferanceResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}
	}
}