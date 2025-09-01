namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class UserService : BusinessObject<User>, IUserService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<User> Validator;

		public UserService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<User> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<User>> DeleteAsync(UserDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<DataService<User>> InsertAsync(UserInsert Model)
		{
			try
			{
				Data = Mapper.Map<User>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<User>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.User.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<User>.SuccessResult(Data, "Record has been success")
					: DataService<User>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<User>.FailureResult(ex.Message, "some error");
			}
		}

		public async Task<DataService<User>> SelectAsync(UserSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<DataService<User>> SelectSingleAsync(UserSelectSingle Model)
		{
			throw new NotImplementedException();
		}

		public async Task<DataService<User>> UpdateAsync(UserUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.User.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null)
					return DataService<User>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				//Data = Mapper.Map(model, Data);
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.User.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<User>.SuccessResult(Data, "Kayıt güncellendi")
					: DataService<User>.FailureResult("Kayıt güncellenemedi");
			}
			catch (Exception ex)
			{
				return DataService<User>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		//public async Task<ServiceResponse<UserResponse>> UpdateAsync(UserUpdate Model)
		//{
		//	Collection = await UnitOfWork.User.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	User User = Collection.SingleOrDefault()!;
		//	User.Name = Model.Name;
		//	await UnitOfWork.User.UpdateAsync(User);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<UserResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<UserResponse>(User)
		//	};
		//}

		//public async Task<ServiceResponse<UserResponse>> DeleteAsync(UserDelete Model)
		//{
		//	Collection = await UnitOfWork.User.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	User User = Collection.SingleOrDefault()!;
		//	await UnitOfWork.User.DeleteAsync(User);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<UserResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<UserResponse>(User)
		//	};
		//}

		//public async Task<ServiceResponse<UserResponse>> SelectAsync(UserSelect Model)
		//{
		//	return new ServiceResponse<UserResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<UserResponse>>
		//		(await UnitOfWork.User.SelectAsync(x => x.IsActive == true))
		//	};
		//}

		//public async Task<ServiceResponse<UserResponse>> SelectSingleAsync(UserSelectSingle Model)
		//{
		//	return new ServiceResponse<UserResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<UserResponse>>
		//		(await UnitOfWork.User.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
		//	};
		//}
	}
}