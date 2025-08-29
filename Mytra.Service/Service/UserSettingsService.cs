namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class UserSettingsService : IUserSettingsService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<UserSettings> Validator;

		public UserSettingsService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<UserSettings> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<UserSettingsResponse>> InsertAsync(UserSettingsInsert Model)
		{
			return new ServiceResponse<UserSettingsResponse>
			{

			};
		}

		public async Task<ServiceResponse<UserSettingsResponse>> UpdateAsync(UserSettingsUpdate Model)
		{
			return new ServiceResponse<UserSettingsResponse>
			{

			};
		}

		public async Task<ServiceResponse<UserSettingsResponse>> DeleteAsync(UserSettingsDelete Model)
		{
			return new ServiceResponse<UserSettingsResponse>
			{

			};
		}

		public async Task<ServiceResponse<UserSettingsResponse>> SelectAsync(UserSettingsSelect Model)
		{
			return new ServiceResponse<UserSettingsResponse>
			{

			};
		}

		public async Task<ServiceResponse<UserSettingsResponse>> SelectSingleAsync(UserSettingsSelectSingle Model)
		{
			return new ServiceResponse<UserSettingsResponse>
			{

			};
		}
	}
}