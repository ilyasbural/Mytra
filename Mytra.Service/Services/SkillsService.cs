namespace Mytra.Service
{
	using Core;
	using Utilize;
	using AutoMapper;
	using FluentValidation;

	public class SkillsService : BusinessObject<Skills>, ISkillsService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<Skills> Validator;

		public SkillsService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Skills> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<Skills>> InsertAsync(SkillsInsert Model)
		{
			try
			{
				Data = Mapper.Map<Skills>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<Skills>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.Skills.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<Skills>.SuccessResult(Data, "Record has been success")
					: DataService<Skills>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<Skills>.FailureResult(ex.Message, "some error");
			}
		}

		public async Task<DataService<Skills>> UpdateAsync(SkillsUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.Skills.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<Skills>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.Skills.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<Skills>.SuccessResult(Data, "Kayıt güncellendi")
					: DataService<Skills>.FailureResult("Kayıt güncellenemedi");
			}
			catch (Exception ex)
			{
				return DataService<Skills>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<Skills>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.Skills.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<Skills>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.Skills.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<Skills>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt silindi")
					: DataService<Skills>.FailureResult("Kayıt silinemedi");
			}
			catch (Exception ex)
			{
				return DataService<Skills>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<Skills>> SelectAsync(SkillsSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.Skills.SelectAsync(x => x.IsActive);
				return DataService<Skills>.SuccessResult(Collection, "Kayıtlar listelendi");
			}
			catch (Exception ex)
			{
				return DataService<Skills>.FailureResult(ex.Message, "Listeleme hatası");
			}
		}

		public async Task<DataService<Skills>> SelectSingleAsync(SkillsSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.Skills.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<Skills>.FailureResult("Kayıt bulunamadı");
				return DataService<Skills>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt bulundu");
			}
			catch (Exception ex)
			{
				return DataService<Skills>.FailureResult(ex.Message, "Sorgu hatası");
			}
		}
	}
}