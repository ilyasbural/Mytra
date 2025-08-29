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
			return new ServiceResponse<CandidateSkillsResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidateSkillsResponse>> UpdateAsync(CandidateSkillsUpdate Model)
		{
			return new ServiceResponse<CandidateSkillsResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidateSkillsResponse>> DeleteAsync(CandidateSkillsDelete Model)
		{
			return new ServiceResponse<CandidateSkillsResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidateSkillsResponse>> SelectAsync(CandidateSkillsSelect Model)
		{
			return new ServiceResponse<CandidateSkillsResponse>()
			{
				//ResponseDataSource = new List<CandidateSkillsResponse>()
				//{
				//	new CandidateSkillsResponse()
				//	{
				//		Id = 1,
				//		CandidateId = 1,
				//		SkillName = "C#",
				//		ProficiencyLevel = "Expert",
				//		YearsOfExperience = 5
				//	},
				//	new CandidateSkillsResponse()
				//	{
				//		Id = 2,
				//		CandidateId = 1,
				//		SkillName = "JavaScript",
				//		ProficiencyLevel = "Intermediate",
				//		YearsOfExperience = 3
				//	}
				//},
				//Success = 1
			};
		}

		public async Task<ServiceResponse<CandidateSkillsResponse>> SelectSingleAsync(CandidateSkillsSelectSingle Model)
		{
			return new ServiceResponse<CandidateSkillsResponse>()
			{
				//ResponseDataSource = new CandidateSkillsResponse()
				//{
				//	Id = 1,
				//	CandidateId = 1,
				//	SkillName = "C#",
				//	ProficiencyLevel = "Expert",
				//	YearsOfExperience = 5
				//},
				//Success = 1
			};
		}
	}
}