namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class UserSettingsService : BusinessObject<UserSettings>, IUserSettingsService
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
			Data = Mapper.Map<UserSettings>(Model);
			Data.Id = Guid.NewGuid();
			Data.RegisterDate = DateTime.Now;
			Data.UpdateDate = DateTime.Now;
			Data.IsActive = true;

			Validator.ValidateAndThrow<UserSettings>(Data);
			await UnitOfWork.UserSettings.InsertAsync(Data);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<UserSettingsResponse>
			{
				Success = Success,
				ResponseData = Mapper.Map<UserSettingsResponse>(Data)
			};
		}

		public async Task<ServiceResponse<UserSettingsResponse>> UpdateAsync(UserSettingsUpdate Model)
		{
			Collection = await UnitOfWork.UserSettings.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			UserSettings UserSettings = Collection.SingleOrDefault()!;
			UserSettings.Name = Model.Name;
			await UnitOfWork.UserSettings.UpdateAsync(UserSettings);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<UserSettingsResponse>
			{
				Success = Success,
				ResponseData = Mapper.Map<UserSettingsResponse>(UserSettings)
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