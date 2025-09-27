namespace Mytra.Service
{
	using Core;
	using Utilize;
	using AutoMapper;
	using FluentValidation;

	public class CollegeService : BusinessObject<College>, ICollegeService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<College> Validator;

		public CollegeService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<College> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<College>> InsertAsync(CollegeInsert Model)
		{
			try
			{
				Data = Mapper.Map<College>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<College>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(), "");
				}

				await UnitOfWork.College.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<College>.SuccessResult(Data, "")
					: DataService<College>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<College>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<College>> UpdateAsync(CollegeUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.College.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<College>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.College.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<College>.SuccessResult(Data, "")
					: DataService<College>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<College>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<College>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.College.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<College>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.College.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<College>.SuccessResult(Collection.SingleOrDefault()!, "")
					: DataService<College>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<College>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<College>> SelectAsync(CollegeSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.College.SelectAsync(x => x.IsActive);
				return DataService<College>.SuccessResult(Collection, "");
			}
			catch (Exception ex)
			{
				return DataService<College>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<College>> SelectSingleAsync(CollegeSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.College.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<College>.FailureResult("");
				return DataService<College>.SuccessResult(Collection.SingleOrDefault()!, "");
			}
			catch (Exception ex)
			{
				return DataService<College>.FailureResult(ex.Message, "");
			}
		}
	}
}