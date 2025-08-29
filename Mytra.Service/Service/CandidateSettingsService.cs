namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateSettingsService : ICandidateSettingsService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateSettings> Validator;

		public CandidateSettingsService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateSettings> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<CandidateSettingsResponse>> InsertAsync(CandidateSettingsInsert Model)
		{
			return new ServiceResponse<CandidateSettingsResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidateSettingsResponse>> UpdateAsync(CandidateSettingsUpdate Model)
		{
			return new ServiceResponse<CandidateSettingsResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidateSettingsResponse>> DeleteAsync(CandidateSettingsDelete Model)
		{
			return new ServiceResponse<CandidateSettingsResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidateSettingsResponse>> SelectAsync(CandidateSettingsSelect Model)
		{
			return new ServiceResponse<CandidateSettingsResponse>()
			{
				//ResponseDataSource = new List<CandidateSettingsResponse>
				//{
				//	new CandidateSettingsResponse
				//	{
				//		Id = 1,
				//		CandidateId = 1,
				//		SettingName = "Notification",
				//		SettingValue = "Email",
				//		CreatedAt = DateTime.UtcNow,
				//		UpdatedAt = DateTime.UtcNow
				//	},
				//	new CandidateSettingsResponse
				//	{
				//		Id = 2,
				//		CandidateId = 1,
				//		SettingName = "Privacy",
				//		SettingValue = "High",
				//		CreatedAt = DateTime.UtcNow,
				//		UpdatedAt = DateTime.UtcNow
				//	}
				//},
				//Success = 1
			};
		}

		public async Task<ServiceResponse<CandidateSettingsResponse>> SelectSingleAsync(CandidateSettingsSelectSingle Model)
		{
			return new ServiceResponse<CandidateSettingsResponse>()
			{
				//ResponseDataSource = new CandidateSettingsResponse
				//{
				//	Id = 1,
				//	CandidateId = 1,
				//	SettingName = "Notification",
				//	SettingValue = "Email",
				//	CreatedAt = DateTime.UtcNow,
				//	UpdatedAt = DateTime.UtcNow
				//},
				//Success = 1
			};
		}
	}
}