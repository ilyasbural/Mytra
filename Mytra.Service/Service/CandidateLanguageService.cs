namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateLanguageService : BusinessObject<CandidateLanguage>, ICandidateLanguageService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateLanguage> Validator;

		public CandidateLanguageService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateLanguage> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<CandidateLanguage>> InsertAsync(CandidateLanguageInsert Model)
		{
			try
			{
				Data = Mapper.Map<CandidateLanguage>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<CandidateLanguage>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.CandidateLanguage.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<CandidateLanguage>.SuccessResult(Data, "Record has been success")
					: DataService<CandidateLanguage>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<CandidateLanguage>.FailureResult(ex.Message, "some error");
			}
		}

		//public async Task<ServiceResponse<CandidateLanguageResponse>> UpdateAsync(CandidateLanguageUpdate Model)
		//{
		//	Collection = await UnitOfWork.CandidateLanguage.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	CandidateLanguage CandidateLanguage = Collection.SingleOrDefault()!;
		//	CandidateLanguage.Name = Model.Name;
		//	await UnitOfWork.CandidateLanguage.UpdateAsync(CandidateLanguage);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CandidateLanguageResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CandidateLanguageResponse>(CandidateLanguage)
		//	};
		//}

		//public async Task<ServiceResponse<CandidateLanguageResponse>> DeleteAsync(CandidateLanguageDelete Model)
		//{
		//	Collection = await UnitOfWork.CandidateLanguage.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	CandidateLanguage CandidateLanguage = Collection.SingleOrDefault()!;
		//	await UnitOfWork.CandidateLanguage.DeleteAsync(CandidateLanguage);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CandidateLanguageResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CandidateLanguageResponse>(CandidateLanguage)
		//	};
		//}

		//public async Task<ServiceResponse<CandidateLanguageResponse>> SelectAsync(CandidateLanguageSelect Model)
		//{
		//	return new ServiceResponse<CandidateLanguageResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<CandidateLanguageResponse>>
		//		(await UnitOfWork.CandidateLanguage.SelectAsync(x => x.IsActive == true))
		//	};
		//}

		//public async Task<ServiceResponse<CandidateLanguageResponse>> SelectSingleAsync(CandidateLanguageSelectSingle Model)
		//{
		//	return new ServiceResponse<CandidateLanguageResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<CandidateLanguageResponse>>
		//		(await UnitOfWork.CandidateLanguage.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
		//	};
		//}
	}
}