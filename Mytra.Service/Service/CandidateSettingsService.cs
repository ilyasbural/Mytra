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

		//public async Task<ServiceResponse<CandidateSettingsResponse>> InsertAsync(CandidateSettingsInsert Model)
		//{
		//	Data = Mapper.Map<CandidateSettings>(Model);
		//	Data.Id = Guid.NewGuid();
		//	Data.RegisterDate = DateTime.Now;
		//	Data.UpdateDate = DateTime.Now;
		//	Data.IsActive = true;

		//	Validator.ValidateAndThrow<CandidateSettings>(Data);
		//	await UnitOfWork.CandidateSettings.InsertAsync(Data);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CandidateSettingsResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CandidateSettingsResponse>(Data)
		//	};
		//}

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