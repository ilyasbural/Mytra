namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class ManagerDetailService : BusinessObject<ManagerDetail>, IManagerDetailService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<ManagerDetail> Validator;

		public ManagerDetailService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ManagerDetail> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<ManagerDetail>> InsertAsync(ManagerDetailInsert Model)
		{
			try
			{
				Data = Mapper.Map<ManagerDetail>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<ManagerDetail>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.ManagerDetail.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<ManagerDetail>.SuccessResult(Data, "Record has been success")
					: DataService<ManagerDetail>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<ManagerDetail>.FailureResult(ex.Message, "some error");
			}
		}

		//public async Task<ServiceResponse<ManagerDetailResponse>> UpdateAsync(ManagerDetailUpdate Model)
		//{
		//	Collection = await UnitOfWork.ManagerDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	ManagerDetail ManagerDetail = Collection.SingleOrDefault()!;
		//	ManagerDetail.Name = Model.Name;
		//	await UnitOfWork.ManagerDetail.UpdateAsync(ManagerDetail);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<ManagerDetailResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<ManagerDetailResponse>(ManagerDetail)
		//	};
		//}

		//public async Task<ServiceResponse<ManagerDetailResponse>> DeleteAsync(ManagerDetailDelete Model)
		//{
		//	Collection = await UnitOfWork.ManagerDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	ManagerDetail ManagerDetail = Collection.SingleOrDefault()!;
		//	await UnitOfWork.ManagerDetail.DeleteAsync(ManagerDetail);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<ManagerDetailResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<ManagerDetailResponse>(ManagerDetail)
		//	};
		//}

		//public async Task<ServiceResponse<ManagerDetailResponse>> SelectAsync(ManagerDetailSelect Model)
		//{
		//	return new ServiceResponse<ManagerDetailResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<ManagerDetailResponse>>
		//		(await UnitOfWork.ManagerDetail.SelectAsync(x => x.IsActive == true))
		//	};
		//}

		//public async Task<ServiceResponse<ManagerDetailResponse>> SelectSingleAsync(ManagerDetailSelectSingle Model)
		//{
		//	return new ServiceResponse<ManagerDetailResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<ManagerDetailResponse>>
		//		(await UnitOfWork.ManagerDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
		//	};
		//}
	}
}