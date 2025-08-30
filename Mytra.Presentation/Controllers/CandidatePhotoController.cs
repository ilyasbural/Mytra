namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

    [ApiController]
    public class CandidatePhotoController : ControllerBase
    {
		readonly ICandidatePhotoService Service;
		public CandidatePhotoController(ICandidatePhotoService service) { Service = service; }

		[HttpPost]
		[Route("api/candidatephoto")]
		[Produces(typeof(ServiceResponse<CandidatePhotoResponse>))]
		public async Task<ServiceResponse<CandidatePhotoResponse>> Create([FromBody] CandidatePhotoInsert Model)
		{
			ServiceResponse<CandidatePhotoResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<CandidatePhotoResponse>
			{
				Success = Response.Success,
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Route("api/candidatephoto")]
		[Produces(typeof(ServiceResponse<CandidatePhotoResponse>))]
		public async Task<ServiceResponse<CandidatePhotoResponse>> Update([FromBody] CandidatePhotoUpdate Model)
		{
			ServiceResponse<CandidatePhotoResponse> Response = await Service.UpdateAsync(Model);
			return new ServiceResponse<CandidatePhotoResponse>
			{
				Success = Response.Success,
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Route("api/candidatephoto")]
		[Produces(typeof(ServiceResponse<CandidatePhotoResponse>))]
		public async Task<ServiceResponse<CandidatePhotoResponse>> Delete([FromBody] CandidatePhotoDelete Model)
		{
			ServiceResponse<CandidatePhotoResponse> Response = await Service.DeleteAsync(Model);
			return new ServiceResponse<CandidatePhotoResponse>
			{
				Success = Response.Success,
				ResponseData = Response.ResponseData
			};
		}

		[HttpGet]
		[Route("api/candidatephoto")]
		[Produces(typeof(ServiceResponse<CandidatePhotoResponse>))]
		public async Task<ServiceResponse<CandidatePhotoResponse>> Get([FromQuery] CandidatePhotoSelect Model)
		{
			ServiceResponse<CandidatePhotoResponse> Response = await Service.SelectAsync(Model);
			return new ServiceResponse<CandidatePhotoResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}

		[HttpGet]
		[Route("api/candidatephotosingle")]
		[Produces(typeof(ServiceResponse<CandidatePhotoResponse>))]
		public async Task<ServiceResponse<CandidatePhotoResponse>> GetSingle([FromQuery] CandidatePhotoSelectSingle Model)
		{
			ServiceResponse<CandidatePhotoResponse> Response = await Service.SelectSingleAsync(Model);
			return new ServiceResponse<CandidatePhotoResponse>
			{
				ResponseDataSource = Response.ResponseDataSource
			};
		}
	}
}