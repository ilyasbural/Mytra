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
			return new ServiceResponse<CandidateExperienceResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidateExperienceResponse>> UpdateAsync(CandidateExperienceUpdate Model)
		{
			return new ServiceResponse<CandidateExperienceResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidateExperienceResponse>> DeleteAsync(CandidateExperienceDelete Model)
		{
			return new ServiceResponse<CandidateExperienceResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidateExperienceResponse>> SelectAsync(CandidateExperienceSelect Model)
		{
			return new ServiceResponse<CandidateExperienceResponse>()
			{
				//ResponseDataSource = new List<CandidateExperienceResponse>()
				//{
				//	new CandidateExperienceResponse()
				//	{
				//		ExperienceId = 1,
				//		CandidateId = 1,
				//		CompanyName = "ABC Corp",
				//		Role = "Software Engineer",
				//		StartDate = new DateTime(2020, 1, 1),
				//		EndDate = new DateTime(2022, 1, 1),
				//		IsCurrent = false,
				//		Description = "Worked on various projects."
				//	},
				//	new CandidateExperienceResponse()
				//	{
				//		ExperienceId = 2,
				//		CandidateId = 1,
				//		CompanyName = "XYZ Inc",
				//		Role = "Senior Developer",
				//		StartDate = new DateTime(2022, 2, 1),
				//		EndDate = null,
				//		IsCurrent = true,
				//		Description = "Leading a team of developers."
				//	}
				//},
				//Success = 1
			};
		}

		public async Task<ServiceResponse<CandidateExperienceResponse>> SelectSingleAsync(CandidateExperienceSelectSingle Model)
		{
			return new ServiceResponse<CandidateExperienceResponse>()
			{
				//ResponseData = new CandidateExperienceResponse()
				//{
				//	ExperienceId = 1,
				//	CandidateId = 1,
				//	CompanyName = "ABC Corp",
				//	Role = "Software Engineer",
				//	StartDate = new DateTime(2020, 1, 1),
				//	EndDate = new DateTime(2022, 1, 1),
				//	IsCurrent = false,
				//	Description = "Worked on various projects."
				//},
				//Success = 1
			};
		}
	}
}