namespace Mytra.Service
{
	using Core;
	using Utilize;
	using AutoMapper;
	using FluentValidation;

	public class CandidateEducationService : BusinessObject<CandidateEducation>, ICandidateEducationService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateEducation> Validator;

		public CandidateEducationService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateEducation> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<CandidateEducation>> InsertAsync(CandidateEducationInsert Model)
		{
			try
			{
				Data = Mapper.Map<CandidateEducation>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<CandidateEducation>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.CandidateEducation.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<CandidateEducation>.SuccessResult(Data, "Record has been success")
					: DataService<CandidateEducation>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<CandidateEducation>.FailureResult(ex.Message, "some error");
			}
		}

		public async Task<DataService<CandidateEducation>> UpdateAsync(CandidateEducationUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateEducation.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<CandidateEducation>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.CandidateEducation.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateEducation>.SuccessResult(Data, "Kayıt güncellendi")
					: DataService<CandidateEducation>.FailureResult("Kayıt güncellenemedi");
			}
			catch (Exception ex)
			{
				return DataService<CandidateEducation>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<CandidateEducation>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.CandidateEducation.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<CandidateEducation>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.CandidateEducation.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateEducation>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt silindi")
					: DataService<CandidateEducation>.FailureResult("Kayıt silinemedi");
			}
			catch (Exception ex)
			{
				return DataService<CandidateEducation>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		public async Task<DataService<CandidateEducation>> SelectAsync(CandidateEducationSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateEducation.SelectAsync(x => x.IsActive);
				return DataService<CandidateEducation>.SuccessResult(Collection, "Kayıtlar listelendi");
			}
			catch (Exception ex)
			{
				return DataService<CandidateEducation>.FailureResult(ex.Message, "Listeleme hatası");
			}
		}

		public async Task<DataService<CandidateEducation>> SelectSingleAsync(CandidateEducationSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateEducation.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<CandidateEducation>.FailureResult("Kayıt bulunamadı");
				return DataService<CandidateEducation>.SuccessResult(Collection.SingleOrDefault()!, "Kayıt bulundu");
			}
			catch (Exception ex)
			{
				return DataService<CandidateEducation>.FailureResult(ex.Message, "Sorgu hatası");
			}
		}
	}
}