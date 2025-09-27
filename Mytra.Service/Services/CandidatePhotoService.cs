namespace Mytra.Service
{
	using Core;
	using Utilize;
	using AutoMapper;
	using FluentValidation;

	public class CandidatePhotoService : BusinessObject<CandidatePhoto>, ICandidatePhotoService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidatePhoto> Validator;

		public CandidatePhotoService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidatePhoto> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<CandidatePhoto>> InsertAsync(CandidatePhotoInsert Model)
		{
			try
			{
				Data = Mapper.Map<CandidatePhoto>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<CandidatePhoto>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(), "");
				}

				await UnitOfWork.CandidatePhoto.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<CandidatePhoto>.SuccessResult(Data, "")
					: DataService<CandidatePhoto>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<CandidatePhoto>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidatePhoto>> UpdateAsync(CandidatePhotoUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidatePhoto.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<CandidatePhoto>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.CandidatePhoto.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidatePhoto>.SuccessResult(Data, "")
					: DataService<CandidatePhoto>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<CandidatePhoto>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidatePhoto>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.CandidatePhoto.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<CandidatePhoto>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.CandidatePhoto.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidatePhoto>.SuccessResult(Collection.SingleOrDefault()!, "")
					: DataService<CandidatePhoto>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<CandidatePhoto>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidatePhoto>> SelectAsync(CandidatePhotoSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidatePhoto.SelectAsync(x => x.IsActive);
				return DataService<CandidatePhoto>.SuccessResult(Collection, "");
			}
			catch (Exception ex)
			{
				return DataService<CandidatePhoto>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidatePhoto>> SelectSingleAsync(CandidatePhotoSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidatePhoto.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<CandidatePhoto>.FailureResult("");
				return DataService<CandidatePhoto>.SuccessResult(Collection.SingleOrDefault()!, "");
			}
			catch (Exception ex)
			{
				return DataService<CandidatePhoto>.FailureResult(ex.Message, "");
			}
		}
	}
}