namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class UserAuthenticationService : BusinessObject<UserAuthentication>, IUserAuthenticationService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<UserAuthentication> Validator;

		public UserAuthenticationService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<UserAuthentication> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<UserAuthentication>> InsertAsync(UserAuthenticationInsert Model)
		{
			try
			{
				Data = Mapper.Map<UserAuthentication>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<UserAuthentication>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.UserAuthentication.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<UserAuthentication>.SuccessResult(Data, "Record has been success")
					: DataService<UserAuthentication>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<UserAuthentication>.FailureResult(ex.Message, "some error");
			}
		}

		//public async Task<ServiceResponse<UserAuthenticationResponse>> UpdateAsync(UserAuthenticationUpdate Model)
		//{
		//	Collection = await UnitOfWork.UserAuthentication.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	UserAuthentication UserAuthentication = Collection.SingleOrDefault()!;
		//	UserAuthentication.Name = Model.Name;
		//	await UnitOfWork.UserAuthentication.UpdateAsync(UserAuthentication);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<UserAuthenticationResponse>
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<UserAuthenticationResponse>(UserAuthentication)
		//	};
		//}

		//public async Task<ServiceResponse<UserAuthenticationResponse>> DeleteAsync(UserAuthenticationDelete Model)
		//{
		//	Collection = await UnitOfWork.UserAuthentication.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	UserAuthentication UserAuthentication = Collection.SingleOrDefault()!;
		//	await UnitOfWork.UserAuthentication.DeleteAsync(UserAuthentication);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<UserAuthenticationResponse>
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<UserAuthenticationResponse>(UserAuthentication)
		//	};
		//}

		//public async Task<ServiceResponse<UserAuthenticationResponse>> SelectAsync(UserAuthenticationSelect Model)
		//{
		//	return new ServiceResponse<UserAuthenticationResponse>
		//	{
		//		ResponseDataSource = Mapper.Map<List<UserAuthenticationResponse>>
		//		(await UnitOfWork.UserAuthentication.SelectAsync(x => x.IsActive == true))
		//	};
		//}

		//public async Task<ServiceResponse<UserAuthenticationResponse>> SelectSingleAsync(UserAuthenticationSelectSingle Model)
		//{
		//	return new ServiceResponse<UserAuthenticationResponse>
		//	{
		//		ResponseDataSource = Mapper.Map<List<UserAuthenticationResponse>>
		//		(await UnitOfWork.UserAuthentication.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
		//	};
		//}
	}
}