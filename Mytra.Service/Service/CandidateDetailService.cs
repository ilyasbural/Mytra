namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateDetailService : ICandidateDetailService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateDetail> Validator;

		public CandidateDetailService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateDetail> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<CandidateDetailResponse>> InsertAsync(CandidateDetailInsert Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateDetailResponse>> UpdateAsync(CandidateDetailUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateDetailResponse>> DeleteAsync(CandidateDetailDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateDetailResponse>> SelectAsync(CandidateDetailSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateDetailResponse>> SelectSingleAsync(CandidateDetailSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}