namespace Mytra.Service
{
	using Core;
	using Utilize;
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
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.ManagerSettings.UpdateAsync(Data);
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

		public async Task<DataService<ManagerSettings>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.ManagerSettings.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<ManagerSettings>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.ManagerSettings.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<ManagerSettings>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt silindi")
					: DataService<ManagerSettings>.FailureResult("Kayıt silinemedi");
			}
			catch (Exception ex)
			{
				return DataService<ManagerSettings>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<ManagerSettings>> SelectAsync(ManagerSettingsSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.ManagerSettings.SelectAsync(x => x.IsActive);
				return DataService<ManagerSettings>.SuccessResult(Collection, "Kayıtlar listelendi");
			}
			catch (Exception ex)
			{
				return DataService<ManagerSettings>.FailureResult(ex.Message, "Listeleme hatası");
			}
		}

		public async Task<DataService<ManagerSettings>> SelectSingleAsync(ManagerSettingsSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.ManagerSettings.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<ManagerSettings>.FailureResult("Kayıt bulunamadı");
				return DataService<ManagerSettings>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt bulundu");
			}
			catch (Exception ex)
			{
				return DataService<ManagerSettings>.FailureResult(ex.Message, "Sorgu hatası");
			}
		}
	}
}