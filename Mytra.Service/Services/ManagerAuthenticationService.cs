namespace Mytra.Service
{
	using Core;
	using Utilize;
	using AutoMapper;
	using FluentValidation;

	public class ManagerAuthenticationService : BusinessObject<ManagerAuthentication>, IManagerAuthenticationService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<ManagerAuthentication> Validator;

		public ManagerAuthenticationService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ManagerAuthentication> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<ManagerAuthentication>> InsertAsync(ManagerAuthenticationInsert Model)
		{
			try
			{
				Data = Mapper.Map<ManagerAuthentication>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<ManagerAuthentication>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.ManagerAuthentication.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<ManagerAuthentication>.SuccessResult(Data, "Record has been success")
					: DataService<ManagerAuthentication>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<ManagerAuthentication>.FailureResult(ex.Message, "some error");
			}
		}

		public async Task<DataService<ManagerAuthentication>> UpdateAsync(ManagerAuthenticationUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.ManagerAuthentication.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<ManagerAuthentication>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.ManagerAuthentication.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<ManagerAuthentication>.SuccessResult(Data, "Kayıt güncellendi")
					: DataService<ManagerAuthentication>.FailureResult("Kayıt güncellenemedi");
			}
			catch (Exception ex)
			{
				return DataService<ManagerAuthentication>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<ManagerAuthentication>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.ManagerAuthentication.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<ManagerAuthentication>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.ManagerAuthentication.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<ManagerAuthentication>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt silindi")
					: DataService<ManagerAuthentication>.FailureResult("Kayıt silinemedi");
			}
			catch (Exception ex)
			{
				return DataService<ManagerAuthentication>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<ManagerAuthentication>> SelectAsync(ManagerAuthenticationSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.ManagerAuthentication.SelectAsync(x => x.IsActive);
				return DataService<ManagerAuthentication>.SuccessResult(Collection, "Kayıtlar listelendi");
			}
			catch (Exception ex)
			{
				return DataService<ManagerAuthentication>.FailureResult(ex.Message, "Listeleme hatası");
			}
		}

		public async Task<DataService<ManagerAuthentication>> SelectSingleAsync(ManagerAuthenticationSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.ManagerAuthentication.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<ManagerAuthentication>.FailureResult("Kayıt bulunamadı");
				return DataService<ManagerAuthentication>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt bulundu");
			}
			catch (Exception ex)
			{
				return DataService<ManagerAuthentication>.FailureResult(ex.Message, "Sorgu hatası");
			}
		}
	}
}