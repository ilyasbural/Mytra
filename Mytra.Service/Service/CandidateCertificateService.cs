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
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateCertificateResponse>> UpdateAsync(CandidateCertificateUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateCertificateResponse>> DeleteAsync(CandidateCertificateDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateCertificateResponse>> SelectAsync(CandidateCertificateSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateCertificateResponse>> SelectSingleAsync(CandidateCertificateSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}