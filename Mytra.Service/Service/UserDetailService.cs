namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class UserDetailService : BusinessObject<UserDetail>, IUserDetailService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<UserDetail> Validator;

		public UserDetailService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<UserDetail> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<UserDetail>> InsertAsync(UserDetailInsert Model)
		{
			try
			{
				Data = Mapper.Map<UserDetail>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<UserDetail>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.UserDetail.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<UserDetail>.SuccessResult(Data, "Record has been success")
					: DataService<UserDetail>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<UserDetail>.FailureResult(ex.Message, "some error");
			}
		}

		//public async Task<ServiceResponse<UserDetailResponse>> UpdateAsync(UserDetailUpdate Model)
		//{
		//	Collection = await UnitOfWork.UserDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	UserDetail UserDetail = Collection.SingleOrDefault()!;
		//	UserDetail.Name = Model.Name;
		//	await UnitOfWork.UserDetail.UpdateAsync(UserDetail);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<UserDetailResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<UserDetailResponse>(UserDetail)
		//	};
		//}

		//public async Task<ServiceResponse<UserDetailResponse>> DeleteAsync(UserDetailDelete Model)
		//{
		//	Collection = await UnitOfWork.UserDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	UserDetail UserDetail = Collection.SingleOrDefault()!;
		//	await UnitOfWork.UserDetail.DeleteAsync(UserDetail);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<UserDetailResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<UserDetailResponse>(UserDetail)
		//	};
		//}

		//public async Task<ServiceResponse<UserDetailResponse>> SelectAsync(UserDetailSelect Model)
		//{
		//	return new ServiceResponse<UserDetailResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<UserDetailResponse>>
		//		(await UnitOfWork.UserDetail.SelectAsync(x => x.IsActive == true))
		//	};
		//}

		//public async Task<ServiceResponse<UserDetailResponse>> SelectSingleAsync(UserDetailSelectSingle Model)
		//{
		//	return new ServiceResponse<UserDetailResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<UserDetailResponse>>
		//		(await UnitOfWork.UserDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
		//	};
		//}
	}
}