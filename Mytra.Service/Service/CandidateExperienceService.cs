namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateExperienceService : BusinessObject<CandidateExperience>, ICandidateExperienceService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateExperience> Validator;

		public CandidateExperienceService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateExperience> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<CandidateExperience>> DeleteAsync(CandidateExperienceDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<DataService<CandidateExperience>> InsertAsync(CandidateExperienceInsert Model)
		{
			try
			{
				Data = Mapper.Map<CandidateExperience>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<CandidateExperience>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.CandidateExperience.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<CandidateExperience>.SuccessResult(Data, "Record has been success")
					: DataService<CandidateExperience>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<CandidateExperience>.FailureResult(ex.Message, "some error");
			}
		}

		public async Task<DataService<CandidateExperience>> SelectAsync(CandidateExperienceSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<DataService<CandidateExperience>> SelectSingleAsync(CandidateExperienceSelectSingle Model)
		{
			throw new NotImplementedException();
		}

		public async Task<DataService<CandidateExperience>> UpdateAsync(CandidateExperienceUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateExperience.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null)
					return DataService<CandidateExperience>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				//Data = Mapper.Map(model, Data);
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.CandidateExperience.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateExperience>.SuccessResult(Data, "Kayıt güncellendi")
					: DataService<CandidateExperience>.FailureResult("Kayıt güncellenemedi");
			}
			catch (Exception ex)
			{
				return DataService<CandidateExperience>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		//public async Task<ServiceResponse<CandidateExperienceResponse>> UpdateAsync(CandidateExperienceUpdate Model)
		//{
		//	Collection = await UnitOfWork.CandidateExperience.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	CandidateExperience CandidateExperience = Collection.SingleOrDefault()!;
		//	CandidateExperience.Name = Model.Name;
		//	await UnitOfWork.CandidateExperience.UpdateAsync(CandidateExperience);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CandidateExperienceResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CandidateExperienceResponse>(CandidateExperience)
		//	};
		//}

		//public async Task<ServiceResponse<CandidateExperienceResponse>> DeleteAsync(CandidateExperienceDelete Model)
		//{
		//	Collection = await UnitOfWork.CandidateExperience.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	CandidateExperience CandidateExperience = Collection.SingleOrDefault()!;
		//	await UnitOfWork.CandidateExperience.DeleteAsync(CandidateExperience);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CandidateExperienceResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CandidateExperienceResponse>(CandidateExperience)
		//	};
		//}

		//public async Task<ServiceResponse<CandidateExperienceResponse>> SelectAsync(CandidateExperienceSelect Model)
		//{
		//	return new ServiceResponse<CandidateExperienceResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<CandidateExperienceResponse>>
		//		(await UnitOfWork.CandidateExperience.SelectAsync(x => x.IsActive == true))
		//	};
		//}

		//public async Task<ServiceResponse<CandidateExperienceResponse>> SelectSingleAsync(CandidateExperienceSelectSingle Model)
		//{
		//	return new ServiceResponse<CandidateExperienceResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<CandidateExperienceResponse>>
		//		(await UnitOfWork.CandidateExperience.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
		//	};
		//}
	}
}