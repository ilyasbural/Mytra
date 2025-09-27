namespace Mytra.Service
{
	using Core;
	using Utilize;
	using AutoMapper;
	using FluentValidation;

	public class CandidateReferanceService : BusinessObject<CandidateReferance>, ICandidateReferanceService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateReferance> Validator;

		public CandidateReferanceService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateReferance> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<CandidateReferance>> InsertAsync(CandidateReferanceInsert Model)
		{
			try
			{
				Data = Mapper.Map<CandidateReferance>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<CandidateReferance>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(), "");
				}

				await UnitOfWork.CandidateReferance.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<CandidateReferance>.SuccessResult(Data, "")
					: DataService<CandidateReferance>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<CandidateReferance>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateReferance>> UpdateAsync(CandidateReferanceUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateReferance.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<CandidateReferance>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.CandidateReferance.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateReferance>.SuccessResult(Data, "")
					: DataService<CandidateReferance>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<CandidateReferance>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateReferance>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.CandidateReferance.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<CandidateReferance>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.CandidateReferance.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateReferance>.SuccessResult(Collection.SingleOrDefault()!, "")
					: DataService<CandidateReferance>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<CandidateReferance>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateReferance>> SelectAsync(CandidateReferanceSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateReferance.SelectAsync(x => x.IsActive);
				return DataService<CandidateReferance>.SuccessResult(Collection, "");
			}
			catch (Exception ex)
			{
				return DataService<CandidateReferance>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateReferance>> SelectSingleAsync(CandidateReferanceSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateReferance.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<CandidateReferance>.FailureResult("");
				return DataService<CandidateReferance>.SuccessResult(Collection.SingleOrDefault()!, "");
			}
			catch (Exception ex)
			{
				return DataService<CandidateReferance>.FailureResult(ex.Message, "");
			}
		}
	}
}