namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateEducationService : ICandidateEducationService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateEducation> Validator;

		public CandidateEducationService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateEducation> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<CandidateEducationResponse>> InsertAsync(CandidateEducationInsert Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateEducationResponse>> UpdateAsync(CandidateEducationUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateEducationResponse>> DeleteAsync(CandidateEducationDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateEducationResponse>> SelectAsync(CandidateEducationSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateEducationResponse>> SelectSingleAsync(CandidateEducationSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}