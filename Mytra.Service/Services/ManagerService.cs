namespace Mytra.Service
{
	using Core;
	using Utilize;
	using AutoMapper;
	using FluentValidation;

	public class ManagerService : BusinessObject<Manager>, IManagerService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<Manager> Validator;

		public ManagerService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Manager> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<Manager>> InsertAsync(ManagerInsert Model)
		{
			try
			{
				Data = Mapper.Map<Manager>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<Manager>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.Manager.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<Manager>.SuccessResult(Data, "Record has been success")
					: DataService<Manager>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<Manager>.FailureResult(ex.Message, "some error");
			}
		}

		public async Task<DataService<Manager>> UpdateAsync(ManagerUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.Manager.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<Manager>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.Manager.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<Manager>.SuccessResult(Data, "Kayıt güncellendi")
					: DataService<Manager>.FailureResult("Kayıt güncellenemedi");
			}
			catch (Exception ex)
			{
				return DataService<Manager>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<Manager>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.Manager.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<Manager>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.Manager.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<Manager>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt silindi")
					: DataService<Manager>.FailureResult("Kayıt silinemedi");
			}
			catch (Exception ex)
			{
				return DataService<Manager>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<Manager>> SelectAsync(ManagerSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.Manager.SelectAsync(x => x.IsActive);
				return DataService<Manager>.SuccessResult(Collection, "Kayıtlar listelendi");
			}
			catch (Exception ex)
			{
				return DataService<Manager>.FailureResult(ex.Message, "Listeleme hatası");
			}
		}

		public async Task<DataService<Manager>> SelectSingleAsync(ManagerSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.Manager.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<Manager>.FailureResult("Kayıt bulunamadı");
				return DataService<Manager>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt bulundu");
			}
			catch (Exception ex)
			{
				return DataService<Manager>.FailureResult(ex.Message, "Sorgu hatası");
			}
		}
	}
}