namespace Mytra.Service
{
	using Core;
	using Utilize;
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
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(), "");
				}

				await UnitOfWork.UserDetail.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<UserDetail>.SuccessResult(Data, "")
					: DataService<UserDetail>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<UserDetail>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<UserDetail>> UpdateAsync(UserDetailUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.UserDetail.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<UserDetail>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.UserDetail.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<UserDetail>.SuccessResult(Data, "")
					: DataService<UserDetail>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<UserDetail>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<UserDetail>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.UserDetail.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<UserDetail>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.UserDetail.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<UserDetail>.SuccessResult(Collection.SingleOrDefault()!, "")
					: DataService<UserDetail>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<UserDetail>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<UserDetail>> SelectAsync(UserDetailSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.UserDetail.SelectAsync(x => x.IsActive);
				return DataService<UserDetail>.SuccessResult(Collection, "");
			}
			catch (Exception ex)
			{
				return DataService<UserDetail>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<UserDetail>> SelectSingleAsync(UserDetailSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.UserDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<UserDetail>.FailureResult("");
				return DataService<UserDetail>.SuccessResult(Collection.SingleOrDefault()!, "");
			}
			catch (Exception ex)
			{
				return DataService<UserDetail>.FailureResult(ex.Message, "");
			}
		}
	}
}