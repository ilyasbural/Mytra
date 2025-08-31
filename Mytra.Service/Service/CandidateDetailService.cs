namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateDetailService : BusinessObject<CandidateDetail>, ICandidateDetailService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateDetail> Validator;

		public CandidateDetailService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateDetail> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public Task<DataService<CandidateDetail>> DeleteAsync(CandidateDetailDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<DataService<CandidateDetail>> InsertAsync(CandidateDetailInsert Model)
		{
			try
			{
				Data = Mapper.Map<CandidateDetail>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<CandidateDetail>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.CandidateDetail.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<CandidateDetail>.SuccessResult(Data, "Record has been success")
					: DataService<CandidateDetail>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<CandidateDetail>.FailureResult(ex.Message, "some error");
			}
		}

		public Task<DataService<CandidateDetail>> SelectAsync(CandidateDetailSelect Model)
		{
			throw new NotImplementedException();
		}

		public Task<DataService<CandidateDetail>> SelectSingleAsync(CandidateDetailSelectSingle Model)
		{
			throw new NotImplementedException();
		}

		public Task<DataService<CandidateDetail>> UpdateAsync(CandidateDetailUpdate Model)
		{
			throw new NotImplementedException();
		}

		//public async Task<ServiceResponse<CandidateDetailResponse>> UpdateAsync(CandidateDetailUpdate Model)
		//{
		//	Collection = await UnitOfWork.CandidateDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	CandidateDetail CandidateDetail = Collection.SingleOrDefault()!;
		//	CandidateDetail.Name = Model.Name;
		//	await UnitOfWork.CandidateDetail.UpdateAsync(CandidateDetail);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CandidateDetailResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CandidateDetailResponse>(CandidateDetail)
		//	};
		//}

		//public async Task<ServiceResponse<CandidateDetailResponse>> DeleteAsync(CandidateDetailDelete Model)
		//{
		//	Collection = await UnitOfWork.CandidateDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	CandidateDetail CandidateDetail = Collection.SingleOrDefault()!;
		//	await UnitOfWork.CandidateDetail.DeleteAsync(CandidateDetail);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CandidateDetailResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CandidateDetailResponse>(CandidateDetail)
		//	};
		//}

		//public async Task<ServiceResponse<CandidateDetailResponse>> SelectAsync(CandidateDetailSelect Model)
		//{
		//	return new ServiceResponse<CandidateDetailResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<CandidateDetailResponse>>
		//		(await UnitOfWork.CandidateDetail.SelectAsync(x => x.IsActive == true))
		//	};
		//}

		//public async Task<ServiceResponse<CandidateDetailResponse>> SelectSingleAsync(CandidateDetailSelectSingle Model)
		//{
		//	return new ServiceResponse<CandidateDetailResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<CandidateDetailResponse>>
		//		(await UnitOfWork.CandidateDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
		//	};
		//}
	}
}