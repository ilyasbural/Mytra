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

		public async Task<DataService<ManagerSettings>> UpdateAsync(ManagerSettingsUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.ManagerSettings.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<ManagerSettings>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				//Data = Mapper.Map(model, Data);
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.ManagerSettings.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<ManagerSettings>.SuccessResult(Data, "Kayıt güncellendi")
					: DataService<ManagerSettings>.FailureResult("Kayıt güncellenemedi");
			}
			catch (Exception ex)
			{
				return DataService<ManagerSettings>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<ManagerSettings>> DeleteAsync(ManagerSettingsDelete Model)
		{
			try
			{
				Collection = await UnitOfWork.Candidate.SelectAsync(x => x.Id == Model.Id);
				if (Collection.SingleOrDefault() == null) return DataService<Candidate>.FailureResult("Kayıt bulunamadı");

				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<Candidate>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt silindi")
					: DataService<Candidate>.FailureResult("Kayıt silinemedi");
			}
			catch (Exception ex)
			{
				return DataService<Candidate>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<ManagerSettings>> SelectAsync(ManagerSettingsSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.Candidate.SelectAsync(x => x.IsActive);
				return DataService<Candidate>.SuccessResult(Collection, "Kayıtlar listelendi");
			}
			catch (Exception ex)
			{
				return DataService<Candidate>.FailureResult(ex.Message, "Listeleme hatası");
			}
		}

		public async Task<DataService<ManagerSettings>> SelectSingleAsync(ManagerSettingsSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.Candidate.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<Candidate>.FailureResult("Kayıt bulunamadı");
				return DataService<Candidate>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt bulundu");
			}
			catch (Exception ex)
			{
				return DataService<Candidate>.FailureResult(ex.Message, "Sorgu hatası");
			}
		}

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