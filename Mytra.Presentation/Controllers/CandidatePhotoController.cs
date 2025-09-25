namespace Mytra.Presentation.Controllers
{
	using Core;
	using Utilize;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;

	[ApiController]
    public class CandidatePhotoController : ControllerBase
    {
		readonly IMapper Mapper;
		readonly ICandidatePhotoService Service;
		public CandidatePhotoController(IMapper mapper, ICandidatePhotoService service)
		{
			Mapper = mapper;
			Service = service;
		}

		[HttpPost]
		[Route("api/candidatephoto")]
		[Produces(typeof(ServiceResponse<CandidatePhotoResponse>))]
		public async Task<ServiceResponse<CandidatePhotoResponse>> Create([FromBody] CandidatePhotoInsert Model)
		{
			DataService<CandidatePhoto> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidatePhotoResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidatePhotoResponse>.FailureResponse("");
			return ServiceResponse<CandidatePhotoResponse>.SuccessResponse(Mapper.Map<CandidatePhotoResponse>(Response.Data), "");
		}

		[HttpPut]
		[Route("api/candidatephoto")]
		[Produces(typeof(ServiceResponse<CandidatePhoto>))]
		public async Task<ServiceResponse<CandidatePhoto>> Update([FromBody] CandidatePhotoUpdate Model)
		{
			DataService<CandidatePhoto> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidatePhoto>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidatePhoto>.FailureResponse("");
			return ServiceResponse<CandidatePhoto>.SuccessResponse(Response.Data, "");
		}

		[HttpDelete]
		[Route("api/candidatephoto/{id}")]
		[Produces(typeof(ServiceResponse<CandidatePhoto>))]
		public async Task<ServiceResponse<CandidatePhoto>> Delete(Guid Id)
		{
			DataService<CandidatePhoto> Response = await Service.DeleteAsync(Id);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidatePhoto>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidatePhoto>.FailureResponse("");
			return ServiceResponse<CandidatePhoto>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Route("api/candidatephoto")]
		[Produces(typeof(ServiceResponse<CandidatePhotoResponse>))]
		public async Task<ServiceResponse<CandidatePhotoResponse>> Get([FromQuery] CandidatePhotoSelect Model)
		{
			DataService<CandidatePhoto> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidatePhotoResponse>.SuccessResponse(Mapper.Map<List<CandidatePhotoResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Route("api/candidatephotosingle")]
		[Produces(typeof(ServiceResponse<CandidatePhotoResponse>))]
		public async Task<ServiceResponse<CandidatePhotoResponse>> GetSingle([FromQuery] CandidatePhotoSelectSingle Model)
		{
			DataService<CandidatePhoto> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CandidatePhotoResponse>.SuccessResponse(Mapper.Map<CandidatePhotoResponse>(Response.Data), "");
		}
	}
}