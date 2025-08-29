namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateReferanceService : ICandidateReferanceService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateReferance> Validator;

		public CandidateReferanceService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateReferance> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<CandidateReferanceResponse>> InsertAsync(CandidateReferanceInsert Model)
		{
			return new ServiceResponse<CandidateReferanceResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidateReferanceResponse>> UpdateAsync(CandidateReferanceUpdate Model)
		{
			return new ServiceResponse<CandidateReferanceResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidateReferanceResponse>> DeleteAsync(CandidateReferanceDelete Model)
		{
			return new ServiceResponse<CandidateReferanceResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidateReferanceResponse>> SelectAsync(CandidateReferanceSelect Model)
		{
			return new ServiceResponse<CandidateReferanceResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidateReferanceResponse>> SelectSingleAsync(CandidateReferanceSelectSingle Model)
		{
			return new ServiceResponse<CandidateReferanceResponse>()
			{

			};
		}
	}
}