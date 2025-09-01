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

		public async Task<DataService<UserSettings>> InsertAsync(UserSettingsInsert Model)
		{
			try
			{
				Data = Mapper.Map<UserSettings>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<UserSettings>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.UserSettings.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<UserSettings>.SuccessResult(Data, "Record has been success")
					: DataService<UserSettings>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<UserSettings>.FailureResult(ex.Message, "some error");
			}
		}

		public async Task<DataService<UserSettings>> UpdateAsync(UserSettingsUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.UserSettings.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null)
					return DataService<UserSettings>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				//Data = Mapper.Map(model, Data);
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.UserSettings.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<UserSettings>.SuccessResult(Data, "Kayıt güncellendi")
					: DataService<UserSettings>.FailureResult("Kayıt güncellenemedi");
			}
			catch (Exception ex)
			{
				return DataService<UserSettings>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<UserSettings>> DeleteAsync(UserSettingsDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<DataService<UserSettings>> SelectAsync(UserSettingsSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<DataService<UserSettings>> SelectSingleAsync(UserSettingsSelectSingle Model)
		{
			throw new NotImplementedException();
		}

		//public async Task<ServiceResponse<UserSettingsResponse>> DeleteAsync(UserSettingsDelete Model)
		//{
		//	Collection = await UnitOfWork.UserSettings.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	UserSettings UserSettings = Collection.SingleOrDefault()!;
		//	await UnitOfWork.UserSettings.DeleteAsync(UserSettings);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<UserSettingsResponse>
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<UserSettingsResponse>(UserSettings)
		//	};
		//}

		//public async Task<ServiceResponse<UserSettingsResponse>> SelectAsync(UserSettingsSelect Model)
		//{
		//	return new ServiceResponse<UserSettingsResponse>
		//	{
		//		ResponseDataSource = Mapper.Map<List<UserSettingsResponse>>
		//		(await UnitOfWork.UserSettings.SelectAsync(x => x.IsActive == true))
		//	};
		//}

		//public async Task<ServiceResponse<UserSettingsResponse>> SelectSingleAsync(UserSettingsSelectSingle Model)
		//{
		//	return new ServiceResponse<UserSettingsResponse>
		//	{
		//		ResponseDataSource = Mapper.Map<List<UserSettingsResponse>>
		//		(await UnitOfWork.UserSettings.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
		//	};
		//}
	}
}