namespace Mytra.Service
{
	using Core;
	using Utilize;
	using AutoMapper;
	using FluentValidation;

	public class CollegeService : BusinessObject<College>, ICollegeService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<College> Validator;

		public CollegeService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<College> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<College>> InsertAsync(CollegeInsert Model)
		{
			try
			{
				Data = Mapper.Map<College>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<College>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.College.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<College>.SuccessResult(Data, "Record has been success")
					: DataService<College>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<College>.FailureResult(ex.Message, "some error");
			}
		}

		public async Task<DataService<College>> UpdateAsync(CollegeUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.College.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<College>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.College.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<College>.SuccessResult(Data, "Kayıt güncellendi")
					: DataService<College>.FailureResult("Kayıt güncellenemedi");
			}
			catch (Exception ex)
			{
				return DataService<College>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<College>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.College.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<College>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.College.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<College>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt silindi")
					: DataService<College>.FailureResult("Kayıt silinemedi");
			}
			catch (Exception ex)
			{
				return DataService<College>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<College>> SelectAsync(CollegeSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.College.SelectAsync(x => x.IsActive);
				return DataService<College>.SuccessResult(Collection, "Kayıtlar listelendi");
			}
			catch (Exception ex)
			{
				return DataService<College>.FailureResult(ex.Message, "Listeleme hatası");
			}
		}

		public async Task<DataService<College>> SelectSingleAsync(CollegeSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.College.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<College>.FailureResult("Kayıt bulunamadı");
				return DataService<College>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt bulundu");
			}
			catch (Exception ex)
			{
				return DataService<College>.FailureResult(ex.Message, "Sorgu hatası");
			}
		}
	}
}