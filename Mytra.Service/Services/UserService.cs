namespace Mytra.Service
{
	using Core;
	using Utilize;
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
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(), "");
				}

				await UnitOfWork.User.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<User>.SuccessResult(Data, "")
					: DataService<User>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<User>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<User>> UpdateAsync(UserUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.User.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<User>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				Data.Email = Model.Email;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.User.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<User>.SuccessResult(Data, "")
					: DataService<User>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<User>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<User>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.User.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<User>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.User.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<User>.SuccessResult(Collection.SingleOrDefault()!, "")
					: DataService<User>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<User>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<User>> SelectAsync(UserSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.User.SelectAsync(x => x.IsActive);
				return DataService<User>.SuccessResult(Collection, "");
			}
			catch (Exception ex)
			{
				return DataService<User>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<User>> SelectSingleAsync(UserSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.User.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<User>.FailureResult("");
				return DataService<User>.SuccessResult(Collection.SingleOrDefault()!, "");
			}
			catch (Exception ex)
			{
				return DataService<User>.FailureResult(ex.Message, "");
			}
		}
	}
}