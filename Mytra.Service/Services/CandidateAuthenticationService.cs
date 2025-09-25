namespace Mytra.Service
{
	using Core;
	using Utilize;
	using AutoMapper;
	using FluentValidation;

	public class CandidateAuthenticationService : BusinessObject<CandidateAuthentication>, ICandidateAuthenticationService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateAuthentication> Validator;

		public CandidateAuthenticationService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateAuthentication> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<CandidateAuthentication>> InsertAsync(CandidateAuthenticationInsert Model)
		{
			try
			{
				List<Candidate> CandidateSingle = await UnitOfWork.Candidate.SelectAsync(x => x.Id == Model.CandidateId);
				Data = new CandidateAuthentication();
				Data.Id = Guid.NewGuid();
				Data.Candidate = CandidateSingle.SingleOrDefault()!;
				Data.RefreshToken = new RefreshTokenGenerator().GenerateRefreshToken();
				Data.RefreshTokenExpireTime = DateTime.UtcNow.AddMonths(1);
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<CandidateAuthentication>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"");
				}

				await UnitOfWork.CandidateAuthentication.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<CandidateAuthentication>.SuccessResult(Data, "")
					: DataService<CandidateAuthentication>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<CandidateAuthentication>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateAuthentication>> UpdateAsync(CandidateAuthenticationUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateAuthentication.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null) return DataService<CandidateAuthentication>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				Data.RefreshToken = Model.RefreshToken;
				Data.RefreshTokenExpireTime = Model.RefreshTokenExpireTime;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.CandidateAuthentication.UpdateAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateAuthentication>.SuccessResult(Data, "")
					: DataService<CandidateAuthentication>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<CandidateAuthentication>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateAuthentication>> DeleteAsync(Guid Id)
		{
			try
			{
				Collection = await UnitOfWork.CandidateAuthentication.SelectAsync(x => x.Id == Id);
				if (Collection.SingleOrDefault() == null) return DataService<CandidateAuthentication>.FailureResult("");

				Data = Collection.SingleOrDefault()!;
				await UnitOfWork.CandidateAuthentication.DeleteAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateAuthentication>.SuccessResult(Collection.SingleOrDefault()!, "")
					: DataService<CandidateAuthentication>.FailureResult("");
			}
			catch (Exception ex)
			{
				return DataService<CandidateAuthentication>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateAuthentication>> SelectAsync(CandidateAuthenticationSelect Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateAuthentication.SelectAsync(x => x.IsActive);
				return DataService<CandidateAuthentication>.SuccessResult(Collection, "");
			}
			catch (Exception ex)
			{
				return DataService<CandidateAuthentication>.FailureResult(ex.Message, "");
			}
		}

		public async Task<DataService<CandidateAuthentication>> SelectSingleAsync(CandidateAuthenticationSelectSingle Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateAuthentication.SelectAsync(x => x.Id == Model.Id && x.IsActive);
				if (Collection == null) return DataService<CandidateAuthentication>.FailureResult("");
				return DataService<CandidateAuthentication>.SuccessResult(Collection.SingleOrDefault()!, "");
			}
			catch (Exception ex)
			{
				return DataService<CandidateAuthentication>.FailureResult(ex.Message, "");
			}
		}
	}
}