namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidatePhotoService : BusinessObject<CandidatePhoto>, ICandidatePhotoService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidatePhoto> Validator;

		public CandidatePhotoService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidatePhoto> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		//public async Task<ServiceResponse<CandidatePhotoResponse>> InsertAsync(CandidatePhotoInsert Model)
		//{
		//	Data = Mapper.Map<CandidatePhoto>(Model);
		//	Data.Id = Guid.NewGuid();
		//	Data.RegisterDate = DateTime.Now;
		//	Data.UpdateDate = DateTime.Now;
		//	Data.IsActive = true;

		//	Validator.ValidateAndThrow<CandidatePhoto>(Data);
		//	await UnitOfWork.CandidatePhoto.InsertAsync(Data);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CandidatePhotoResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CandidatePhotoResponse>(Data)
		//	};
		//}

		//public async Task<ServiceResponse<CandidatePhotoResponse>> UpdateAsync(CandidatePhotoUpdate Model)
		//{
		//	Collection = await UnitOfWork.CandidatePhoto.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	CandidatePhoto CandidatePhoto = Collection.SingleOrDefault()!;
		//	CandidatePhoto.Name = Model.Name;
		//	await UnitOfWork.CandidatePhoto.UpdateAsync(CandidatePhoto);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CandidatePhotoResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CandidatePhotoResponse>(CandidatePhoto)
		//	};
		//}

		//public async Task<ServiceResponse<CandidatePhotoResponse>> DeleteAsync(CandidatePhotoDelete Model)
		//{
		//	Collection = await UnitOfWork.CandidatePhoto.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	CandidatePhoto CandidatePhoto = Collection.SingleOrDefault()!;
		//	await UnitOfWork.CandidatePhoto.DeleteAsync(CandidatePhoto);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CandidatePhotoResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CandidatePhotoResponse>(CandidatePhoto)
		//	};
		//}

		//public async Task<ServiceResponse<CandidatePhotoResponse>> SelectAsync(CandidatePhotoSelect Model)
		//{
		//	return new ServiceResponse<CandidatePhotoResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<CandidatePhotoResponse>>
		//		(await UnitOfWork.CandidatePhoto.SelectAsync(x => x.IsActive == true))
		//	};
		//}

		//public async Task<ServiceResponse<CandidatePhotoResponse>> SelectSingleAsync(CandidatePhotoSelectSingle Model)
		//{
		//	return new ServiceResponse<CandidatePhotoResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<CandidatePhotoResponse>>
		//		(await UnitOfWork.CandidatePhoto.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
		//	};
		//}
	}
}