namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class LanguageService : BusinessObject<Language>, ILanguageService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<Language> Validator;

		public LanguageService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Language> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<Language>> InsertAsync(LanguageInsert Model)
		{
			try
			{
				Data = Mapper.Map<Language>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<Language>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.Language.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<Language>.SuccessResult(Data, "Record has been success")
					: DataService<Language>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<Language>.FailureResult(ex.Message, "some error");
			}
		}

		//public async Task<ServiceResponse<LanguageResponse>> UpdateAsync(LanguageUpdate Model)
		//{
		//	Collection = await UnitOfWork.Language.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	Language Language = Collection.SingleOrDefault()!;
		//	Language.Name = Model.Name;
		//	await UnitOfWork.Language.UpdateAsync(Language);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<LanguageResponse>
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<LanguageResponse>(Language)
		//	};
		//}

		//public async Task<ServiceResponse<LanguageResponse>> DeleteAsync(LanguageDelete Model)
		//{
		//	Collection = await UnitOfWork.Language.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	Language Language = Collection.SingleOrDefault()!;
		//	await UnitOfWork.Language.DeleteAsync(Language);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<LanguageResponse>
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<LanguageResponse>(Language)
		//	};
		//}

		//public async Task<ServiceResponse<LanguageResponse>> SelectAsync(LanguageSelect Model)
		//{
		//	return new ServiceResponse<LanguageResponse>
		//	{
		//		ResponseDataSource = Mapper.Map<List<LanguageResponse>>
		//		(await UnitOfWork.Language.SelectAsync(x => x.IsActive == true))
		//	};
		//}

		//public async Task<ServiceResponse<LanguageResponse>> SelectSingleAsync(LanguageSelectSingle Model)
		//{
		//	return new ServiceResponse<LanguageResponse>
		//	{
		//		ResponseDataSource = Mapper.Map<List<LanguageResponse>>
		//		(await UnitOfWork.Language.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
		//	};
		//}
	}
}