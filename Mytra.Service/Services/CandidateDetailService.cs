namespace Mytra.Service
{
	using Core;
	using Utilize;
	using AutoMapper;
	using FluentValidation;

	public class CandidateDetailService : BusinessObject<CandidateDetail>, ICandidateDetailService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateDetail> Validator;

		public CandidateDetailService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateDetail> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<CandidateDetail>> InsertAsync(CandidateDetailInsert Model)
		{
			try
			{
				Data = Mapper.Map<CandidateDetail>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<CandidateDetail>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(), "");
				}

				await UnitOfWork.CandidateDetail.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<CandidateDetail>.SuccessResult(Data, "")
					: DataService<CandidateDetail>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<CandidateDetail>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateDetail>> UpdateAsync(CandidateDetailUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateDetail.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<CandidateDetail>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.CandidateDetail.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateDetail>.SuccessResult(Data, "")
					: DataService<CandidateDetail>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<CandidateDetail>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateDetail>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.CandidateDetail.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<CandidateDetail>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.CandidateDetail.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateDetail>.SuccessResult(Collection.SingleOrDefault()!, "")
					: DataService<CandidateDetail>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<CandidateDetail>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateDetail>> SelectAsync(CandidateDetailSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateDetail.SelectAsync(x => x.IsActive);
				return DataService<CandidateDetail>.SuccessResult(Collection, "");
			}
			catch (Exception ex)
			{
				return DataService<CandidateDetail>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateDetail>> SelectSingleAsync(CandidateDetailSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<CandidateDetail>.FailureResult("");
				return DataService<CandidateDetail>.SuccessResult(Collection.SingleOrDefault()!, "");
			}
			catch (Exception ex)
			{
				return DataService<CandidateDetail>.FailureResult(ex.Message, "");
			}
		}
	}
}