namespace Mytra.Presentation.Controllers
{
	using Core;
	using Common;
	using AutoMapper;
	using Microsoft.AspNetCore.Mvc;
	using Microsoft.AspNetCore.Authorization;

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
		[Route("api/candidate")]
		[Produces(typeof(ServiceResponse<CandidateResponse>))]
		public async Task<ServiceResponse<CandidateResponse>> Create([FromBody] CandidateInsert Model)
		{
			DataService<Candidate> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidateResponse>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidateResponse>.FailureResponse("");
			return ServiceResponse<CandidateResponse>.SuccessResponse(Mapper.Map<List<CandidateResponse>>(Response.Data), "");
		}

		[HttpPost]
		[Authorize]
		[Route("api/candidatephoto")]
		[Produces(typeof(ServiceResponse<CandidatePhoto>))]
		public async Task<ServiceResponse<CandidatePhoto>> Create([FromBody] CandidatePhotoInsert Model)
		{
			DataService<CandidatePhoto> Response = await Service.InsertAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidatePhoto>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidatePhoto>.FailureResponse("");
			return ServiceResponse<CandidatePhoto>.SuccessResponse(Response.Data, "");
		}

		[HttpPut]
		[Authorize]
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
		[Authorize]
		[Route("api/candidatephoto")]
		[Produces(typeof(ServiceResponse<CandidatePhoto>))]
		public async Task<ServiceResponse<CandidatePhoto>> Delete([FromBody] CandidatePhotoDelete Model)
		{
			DataService<CandidatePhoto> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<CandidatePhoto>.FailureResponse(Response.Errors, "");
			if (!Response.Success) return ServiceResponse<CandidatePhoto>.FailureResponse("");
			return ServiceResponse<CandidatePhoto>.SuccessResponse(Response.Data, "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidatephoto")]
		[Produces(typeof(ServiceResponse<CandidatePhotoResponse>))]
		public async Task<ServiceResponse<CandidatePhotoResponse>> Get([FromQuery] CandidatePhotoSelect Model)
		{
			DataService<CandidatePhoto> Response = await Service.SelectAsync(Model);
			return ServiceResponse<CandidatePhotoResponse>.SuccessResponse(Mapper.Map<List<CandidatePhotoResponse>>(Response.DataList), "");
		}

		[HttpGet]
		[Authorize]
		[Route("api/candidatephotosingle")]
		[Produces(typeof(ServiceResponse<CandidatePhotoResponse>))]
		public async Task<ServiceResponse<CandidatePhotoResponse>> GetSingle([FromQuery] CandidatePhotoSelectSingle Model)
		{
			DataService<CandidatePhoto> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<CandidatePhotoResponse>.SuccessResponse(Mapper.Map<List<CandidatePhotoResponse>>(Response.Data), "");
		}
	}
}