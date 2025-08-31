namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateSettingsService : BusinessObject<CandidateSettings>, ICandidateSettingsService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateSettings> Validator;

		public CandidateSettingsService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateSettings> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<CandidateSettings>> InsertAsync(CandidateSettingsInsert Model)
		{
			try
			{
				Data = Mapper.Map<CandidateSettings>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<CandidateSettings>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.CandidateSettings.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<CandidateSettings>.SuccessResult(Data, "Record has been success")
					: DataService<CandidateSettings>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<CandidateSettings>.FailureResult(ex.Message, "some error");
			}
		}

		//public async Task<ServiceResponse<CandidateSettingsResponse>> UpdateAsync(CandidateSettingsUpdate Model)
		//{
		//	Collection = await UnitOfWork.CandidateSettings.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	CandidateSettings CandidateSettings = Collection.SingleOrDefault()!;
		//	CandidateSettings.Name = Model.Name;
		//	await UnitOfWork.CandidateSettings.UpdateAsync(CandidateSettings);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CandidateSettingsResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CandidateSettingsResponse>(CandidateSettings)
		//	};
		//}

		//public async Task<ServiceResponse<CandidateSettingsResponse>> DeleteAsync(CandidateSettingsDelete Model)
		//{
		//	Collection = await UnitOfWork.CandidateSettings.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	CandidateSettings CandidateSettings = Collection.SingleOrDefault()!;
		//	await UnitOfWork.CandidateSettings.DeleteAsync(CandidateSettings);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CandidateSettingsResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CandidateSettingsResponse>(CandidateSettings)
		//	};
		//}

		//public async Task<ServiceResponse<CandidateSettingsResponse>> SelectAsync(CandidateSettingsSelect Model)
		//{
		//	return new ServiceResponse<CandidateSettingsResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<CandidateSettingsResponse>>
		//		(await UnitOfWork.CandidateSettings.SelectAsync(x => x.IsActive == true))
		//	};
		//}

		//public async Task<ServiceResponse<CandidateSettingsResponse>> SelectSingleAsync(CandidateSettingsSelectSingle Model)
		//{
		//	return new ServiceResponse<CandidateSettingsResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<CandidateSettingsResponse>>
		//		(await UnitOfWork.CandidateSettings.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
		//	};
		//}
	}
}