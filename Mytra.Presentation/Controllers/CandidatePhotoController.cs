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
		[Authorize]
		[Route("api/candidatephoto")]
		[Produces(typeof(ServiceResponse<CandidatePhotoResponse>))]
		public async Task<ServiceResponse<CandidatePhotoResponse>> Create([FromBody] CandidatePhotoInsert Model)
		{
			ServiceResponse<CandidatePhotoResponse> Response = await Service.InsertAsync(Model);
			return new ServiceResponse<CandidatePhotoResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpPut]
		[Authorize]
		[Route("api/candidatephoto")]
		[Produces(typeof(ServiceResponse<CandidatePhotoResponse>))]
		public async Task<ServiceResponse<CandidatePhotoResponse>> Update([FromBody] CandidatePhotoUpdate Model)
		{
			ServiceResponse<CandidatePhotoResponse> Response = await Service.UpdateAsync(Model);
			return new ServiceResponse<CandidatePhotoResponse>
			{
				ResponseData = Response.ResponseData
			};
		}

		[HttpDelete]
		[Authorize]
		[Route("api/candidatephoto")]
		[Produces(typeof(ServiceResponse<CandidatePhotoResponse>))]
		public async Task<ServiceResponse<CandidatePhotoResponse>> Delete([FromBody] CandidatePhotoDelete Model)
		{
			ServiceResponse<CandidatePhotoResponse> Response = await Service.DeleteAsync(Model);
			return new ServiceResponse<CandidatePhotoResponse>
			{
				ResponseData = Response.ResponseData
			};
		}
	}
}