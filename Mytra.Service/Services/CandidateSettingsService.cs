namespace Mytra.Service
{
	using Core;
	using Utilize;
	using AutoMapper;
	using FluentValidation;

	public class CandidateSettingsService : BusinessObject<CandidateSettings>, ICandidateSettingsService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateSettings> Validator;

		public CandidateSettingsService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateSettings> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<CandidateSettings>> InsertAsync(CandidateSettingsInsert Model)
		{
			try
			{
				Data = Mapper.Map<CandidateSettings>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<CandidateSettings>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(), "");
				}

				await UnitOfWork.CandidateSettings.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<CandidateSettings>.SuccessResult(Data, "")
					: DataService<CandidateSettings>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<CandidateSettings>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateSettings>> UpdateAsync(CandidateSettingsUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateSettings.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<CandidateSettings>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.CandidateSettings.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateSettings>.SuccessResult(Data, "")
					: DataService<CandidateSettings>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<CandidateSettings>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateSettings>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.CandidateSettings.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<CandidateSettings>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.CandidateSettings.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateSettings>.SuccessResult(Collection.SingleOrDefault()!, "")
					: DataService<CandidateSettings>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<CandidateSettings>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateSettings>> SelectAsync(CandidateSettingsSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateSettings.SelectAsync(x => x.IsActive);
				return DataService<CandidateSettings>.SuccessResult(Collection, "");
			}
			catch (Exception ex)
			{
				return DataService<CandidateSettings>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateSettings>> SelectSingleAsync(CandidateSettingsSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateSettings.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<CandidateSettings>.FailureResult("");
				return DataService<CandidateSettings>.SuccessResult(Collection.SingleOrDefault()!, "");
			}
			catch (Exception ex)
			{
				return DataService<CandidateSettings>.FailureResult(ex.Message, "");
			}
		}
	}
}