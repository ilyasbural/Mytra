namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateSkillsService : ICandidateSkillsService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateSkills> Validator;

		public CandidateSkillsService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateSkills> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<CandidateSkillsResponse>> InsertAsync(CandidateSkillsInsert Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateSkillsResponse>> UpdateAsync(CandidateSkillsUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateSkillsResponse>> DeleteAsync(CandidateSkillsDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateSkillsResponse>> SelectAsync(CandidateSkillsSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateSkillsResponse>> SelectSingleAsync(CandidateSkillsSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}