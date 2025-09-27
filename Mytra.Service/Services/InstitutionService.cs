namespace Mytra.Service
{
	using Core;
	using Utilize;
	using AutoMapper;
	using FluentValidation;

	public class InstitutionService : BusinessObject<Institution>, IInstitutionService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<Institution> Validator;

		public InstitutionService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Institution> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<Institution>> InsertAsync(InstitutionInsert Model)
		{
			try
			{
				Data = Mapper.Map<Institution>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<Institution>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(), "");
				}

				await UnitOfWork.Institution.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<Institution>.SuccessResult(Data, "")
					: DataService<Institution>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<Institution>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<Institution>> UpdateAsync(InstitutionUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.Institution.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<Institution>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.Institution.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<Institution>.SuccessResult(Data, "")
					: DataService<Institution>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<Institution>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<Institution>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.Institution.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<Institution>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.Institution.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<Institution>.SuccessResult(Collection.SingleOrDefault()!, "")
					: DataService<Institution>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<Institution>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<Institution>> SelectAsync(InstitutionSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.Institution.SelectAsync(x => x.IsActive);
				return DataService<Institution>.SuccessResult(Collection, "");
			}
			catch (Exception ex)
			{
				return DataService<Institution>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<Institution>> SelectSingleAsync(InstitutionSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.Institution.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<Institution>.FailureResult("");
				return DataService<Institution>.SuccessResult(Collection.SingleOrDefault()!, "");
			}
			catch (Exception ex)
			{
				return DataService<Institution>.FailureResult(ex.Message, "");
			}
		}
	}
}