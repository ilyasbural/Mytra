namespace Mytra.Presentation.Controllers
{
	using Azure;
	using Common;
	using Core;
	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Mvc;

    [ApiController]
    public class CandidateController : ControllerBase
    {
		readonly ICandidateService Service;
		public CandidateController(ICandidateService service) { Service = service; }

		[HttpPost]
		[Route("api/candidate")]
		[Produces(typeof(ServiceResponse<Candidate>))]
		public async Task<ServiceResponse<Candidate>> Create([FromBody] CandidateInsert Model)
		{
			DataService<Candidate> Response = await Service.InsertAsync(Model);		
			if (Response.Errors.Count > 0) return ServiceResponse<Candidate>.FailureResponse(Response.Errors, "Validasyon hatası");
			if (!Response.Success) return ServiceResponse<Candidate>.FailureResponse("Aday kaydedilemedi");
			return ServiceResponse<Candidate>.SuccessResponse(Response.Data, "Aday kaydedildi");
		}

		[HttpPut]
		[Route("api/candidate")]
		[Produces(typeof(ServiceResponse<Candidate>))]
		public async Task<ServiceResponse<Candidate>> Update([FromBody] CandidateUpdate Model)
		{
			DataService<Candidate> Response = await Service.UpdateAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<Candidate>.FailureResponse(Response.Errors, "Validasyon hatası");
			if (!Response.Success) return ServiceResponse<Candidate>.FailureResponse("Aday güncellenemedi");
			return ServiceResponse<Candidate>.SuccessResponse(Response.Data, "Aday güncellendi");
		}

		[HttpDelete]
		[Route("api/candidate")]
		[Produces(typeof(ServiceResponse<Candidate>))]
		public async Task<ServiceResponse<Candidate>> Delete([FromBody] CandidateDelete Model)
		{
			DataService<Candidate> Response = await Service.DeleteAsync(Model);
			if (Response.Errors.Count > 0) return ServiceResponse<Candidate>.FailureResponse(Response.Errors, "Validasyon hatası");
			if (!Response.Success) return ServiceResponse<Candidate>.FailureResponse("Aday silinemedi");
			return ServiceResponse<Candidate>.SuccessResponse(Response.Data, "Aday silindi");
		}

		[HttpGet]
		[Route("api/candidate")]
		[Produces(typeof(ServiceResponse<Candidate>))]
		public async Task<ServiceResponse<Candidate>> Get([FromQuery] CandidateSelect Model)
		{
			DataService<Candidate> Response = await Service.SelectAsync(Model);
			return ServiceResponse<Candidate>.SuccessResponse(Response.DataList, "Aday listesi eklendi");
		}

		[HttpGet]
		[Route("api/candidatesingle")]
		[Produces(typeof(ServiceResponse<Candidate>))]
		public async Task<ServiceResponse<Candidate>> GetSingle([FromQuery] CandidateSelectSingle Model)
		{
			DataService<Candidate> Response = await Service.SelectSingleAsync(Model);
			return ServiceResponse<Candidate>.SuccessResponse(Response.Data, "Aday getirildi");
		}
	}
}