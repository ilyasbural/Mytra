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
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<UserSettingsResponse>> UpdateAsync(UserSettingsUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<UserSettingsResponse>> DeleteAsync(UserSettingsDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<UserSettingsResponse>> SelectAsync(UserSettingsSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<UserSettingsResponse>> SelectSingleAsync(UserSettingsSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}