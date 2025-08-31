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

		public Task<DataService<CandidatePhoto>> DeleteAsync(CandidatePhotoDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<DataService<CandidatePhoto>> InsertAsync(CandidatePhotoInsert Model)
		{
			try
			{
				Data = Mapper.Map<CandidatePhoto>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<CandidatePhoto>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.CandidatePhoto.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<CandidatePhoto>.SuccessResult(Data, "Record has been success")
					: DataService<CandidatePhoto>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<CandidatePhoto>.FailureResult(ex.Message, "some error");
			}
		}

		public Task<DataService<CandidatePhoto>> SelectAsync(CandidatePhotoSelect Model)
		{
			throw new NotImplementedException();
		}

		public Task<DataService<CandidatePhoto>> SelectSingleAsync(CandidatePhotoSelectSingle Model)
		{
			throw new NotImplementedException();
		}

		public Task<DataService<CandidatePhoto>> UpdateAsync(CandidatePhotoUpdate Model)
		{
			throw new NotImplementedException();
		}

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