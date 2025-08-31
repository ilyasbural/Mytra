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