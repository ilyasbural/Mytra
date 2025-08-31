namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class ManagerSettingsService : BusinessObject<ManagerSettings>, IManagerSettingsService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<ManagerSettings> Validator;

		public ManagerSettingsService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ManagerSettings> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<ManagerSettings>> InsertAsync(ManagerSettingsInsert Model)
		{
			try
			{
				Data = Mapper.Map<ManagerSettings>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<ManagerSettings>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.ManagerSettings.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<ManagerSettings>.SuccessResult(Data, "Record has been success")
					: DataService<ManagerSettings>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<ManagerSettings>.FailureResult(ex.Message, "some error");
			}
		}

		//public async Task<ServiceResponse<ManagerSettingsResponse>> UpdateAsync(ManagerSettingsUpdate Model)
		//{
		//	Collection = await UnitOfWork.ManagerSettings.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	ManagerSettings ManagerSettings = Collection.SingleOrDefault()!;
		//	ManagerSettings.Name = Model.Name;
		//	await UnitOfWork.ManagerSettings.UpdateAsync(ManagerSettings);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<ManagerSettingsResponse>
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<ManagerSettingsResponse>(ManagerSettings)
		//	};
		//}

		//public async Task<ServiceResponse<ManagerSettingsResponse>> DeleteAsync(ManagerSettingsDelete Model)
		//{
		//	Collection = await UnitOfWork.ManagerSettings.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	ManagerSettings ManagerSettings = Collection.SingleOrDefault()!;
		//	await UnitOfWork.ManagerSettings.DeleteAsync(ManagerSettings);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<ManagerSettingsResponse>
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<ManagerSettingsResponse>(ManagerSettings)
		//	};
		//}

		//public async Task<ServiceResponse<ManagerSettingsResponse>> SelectAsync(ManagerSettingsSelect Model)
		//{
		//	return new ServiceResponse<ManagerSettingsResponse>
		//	{
		//		ResponseDataSource = Mapper.Map<List<ManagerSettingsResponse>>
		//		(await UnitOfWork.ManagerSettings.SelectAsync(x => x.IsActive == true))
		//	};
		//}

		//public async Task<ServiceResponse<ManagerSettingsResponse>> SelectSingleAsync(ManagerSettingsSelectSingle Model)
		//{
		//	return new ServiceResponse<ManagerSettingsResponse>
		//	{
		//		ResponseDataSource = Mapper.Map<List<ManagerSettingsResponse>>
		//		(await UnitOfWork.ManagerSettings.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
		//	};
		//}
	}
}