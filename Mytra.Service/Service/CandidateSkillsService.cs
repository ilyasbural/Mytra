namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateSkillsService : BusinessObject<CandidateSkills>, ICandidateSkillsService
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
			Data = Mapper.Map<CandidateSkills>(Model);
			Data.Id = Guid.NewGuid();
			Data.RegisterDate = DateTime.Now;
			Data.UpdateDate = DateTime.Now;
			Data.IsActive = true;

			Validator.ValidateAndThrow<CandidateSkills>(Data);
			await UnitOfWork.CandidateSkills.InsertAsync(Data);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<CandidateSkillsResponse>()
			{
				Success = Success,
				ResponseData = Mapper.Map<CandidateSkillsResponse>(Data)
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