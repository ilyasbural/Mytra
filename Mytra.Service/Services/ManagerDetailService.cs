namespace Mytra.Service
{
	using Core;
	using Utilize;
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
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(), "");
				}

				await UnitOfWork.ManagerDetail.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<ManagerDetail>.SuccessResult(Data, "")
					: DataService<ManagerDetail>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<ManagerDetail>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<ManagerDetail>> UpdateAsync(ManagerDetailUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.ManagerDetail.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<ManagerDetail>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.ManagerDetail.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<ManagerDetail>.SuccessResult(Data, "")
					: DataService<ManagerDetail>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<ManagerDetail>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<ManagerDetail>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.ManagerDetail.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<ManagerDetail>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.ManagerDetail.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<ManagerDetail>.SuccessResult(Collection.SingleOrDefault()!, "")
					: DataService<ManagerDetail>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<ManagerDetail>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<ManagerDetail>> SelectAsync(ManagerDetailSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.ManagerDetail.SelectAsync(x => x.IsActive);
				return DataService<ManagerDetail>.SuccessResult(Collection, "");
			}
			catch (Exception ex)
			{
				return DataService<ManagerDetail>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<ManagerDetail>> SelectSingleAsync(ManagerDetailSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.ManagerDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<ManagerDetail>.FailureResult("");
				return DataService<ManagerDetail>.SuccessResult(Collection.SingleOrDefault()!, "");
			}
			catch (Exception ex)
			{
				return DataService<ManagerDetail>.FailureResult(ex.Message, "");
			}
		}
	}
}