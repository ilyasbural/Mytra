namespace Mytra.Service
{
	using Core;
	using Utilize;
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
					? DataService<UserAuthentication>.SuccessResult(Data, "")
					: DataService<UserAuthentication>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<UserAuthentication>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<UserAuthentication>> UpdateAsync(UserAuthenticationUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.UserAuthentication.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<UserAuthentication>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				Data.RefreshToken = Model.RefreshToken;
				Data.RefreshTokenExpireTime = DateTime.Now;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.UserAuthentication.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<UserAuthentication>.SuccessResult(Data, "")
					: DataService<UserAuthentication>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<UserAuthentication>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<UserAuthentication>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.UserAuthentication.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<UserAuthentication>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.UserAuthentication.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<UserAuthentication>.SuccessResult(Collection.SingleOrDefault()!, "")
					: DataService<UserAuthentication>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<UserAuthentication>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<UserAuthentication>> SelectAsync(UserAuthenticationSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.UserAuthentication.SelectAsync(x => x.IsActive);
				return DataService<UserAuthentication>.SuccessResult(Collection, "");
			}
			catch (Exception ex)
			{
				return DataService<UserAuthentication>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<UserAuthentication>> SelectSingleAsync(UserAuthenticationSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.UserAuthentication.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<UserAuthentication>.FailureResult("");
				return DataService<UserAuthentication>.SuccessResult(Collection.SingleOrDefault()!, "");
			}
			catch (Exception ex)
			{
				return DataService<UserAuthentication>.FailureResult(ex.Message, "");
			}
		}
	}
}