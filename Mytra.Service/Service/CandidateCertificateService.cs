namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateCertificateService : ICandidateCertificateService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateAuthentication> Validator;

		public CandidateCertificateService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateAuthentication> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<CandidateCertificateResponse>> InsertAsync(CandidateCertificateInsert Model)
		{
			return new ServiceResponse<CandidateCertificateResponse>()
			{
				//ResponseData = new CandidateCertificateResponse()
				//{
				//	Success = 1
				//},
				//ResponseDataSource = new List<CandidateCertificateResponse>(),
				//Success = 1
			};
		}

		public async Task<ServiceResponse<CandidateCertificateResponse>> UpdateAsync(CandidateCertificateUpdate Model)
		{
			return new ServiceResponse<CandidateCertificateResponse>()
			{
				//ResponseData = new CandidateCertificateResponse()
				//{
				//	Success = 1
				//},
				//ResponseDataSource = new List<CandidateCertificateResponse>(),
				//Success = 1
			};
		}

		public async Task<ServiceResponse<CandidateCertificateResponse>> DeleteAsync(CandidateCertificateDelete Model)
		{
			return new ServiceResponse<CandidateCertificateResponse>()
			{
				//ResponseData = new CandidateCertificateResponse()
				//{
				//	Success = 1
				//},
				//ResponseDataSource = new List<CandidateCertificateResponse>(),
				//Success = 1
			};
		}

		public async Task<ServiceResponse<CandidateCertificateResponse>> SelectAsync(CandidateCertificateSelect Model)
		{
			return new ServiceResponse<CandidateCertificateResponse>()
			{
				//ResponseData = new CandidateCertificateResponse()
				//{
				//	Success = 1
				//},
				//ResponseDataSource = new List<CandidateCertificateResponse>(),
				//Success = 1
			};
		}

		public async Task<ServiceResponse<CandidateCertificateResponse>> SelectSingleAsync(CandidateCertificateSelectSingle Model)
		{
			return new ServiceResponse<CandidateCertificateResponse>()
			{
				//ResponseData = new CandidateCertificateResponse()
				//{
				//	Success = 1
				//},
				//ResponseDataSource = new List<CandidateCertificateResponse>(),
				//Success = 1
			};
		}
	}
}