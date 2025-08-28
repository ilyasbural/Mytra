namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateExperienceService : ICandidateExperienceService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateExperience> Validator;

		public CandidateExperienceService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateExperience> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<CandidateExperienceResponse>> InsertAsync(CandidateExperienceInsert Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateExperienceResponse>> UpdateAsync(CandidateExperienceUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateExperienceResponse>> DeleteAsync(CandidateExperienceDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateExperienceResponse>> SelectAsync(CandidateExperienceSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateExperienceResponse>> SelectSingleAsync(CandidateExperienceSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}