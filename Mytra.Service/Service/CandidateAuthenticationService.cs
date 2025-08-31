namespace Mytra.Service
{
	using Core;
	using Common;
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
				Data = Mapper.Map<CandidateAuthentication>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<CandidateAuthentication>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.CandidateAuthentication.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<CandidateAuthentication>.SuccessResult(Data, "Record has been success")
					: DataService<CandidateAuthentication>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<CandidateAuthentication>.FailureResult(ex.Message, "some error");
			}
		}

		public async Task<DataService<CandidateAuthentication>> UpdateAsync(CandidateAuthenticationUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateAuthentication.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null)
					return DataService<CandidateAuthentication>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				//Data = Mapper.Map(model, Data);
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.CandidateAuthentication.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateAuthentication>.SuccessResult(Data, "Kayıt güncellendi")
					: DataService<CandidateAuthentication>.FailureResult("Kayıt güncellenemedi");
			}
			catch (Exception ex)
			{
				return DataService<CandidateAuthentication>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		//public async Task<ServiceResponse<CandidateAuthenticationResponse>> DeleteAsync(CandidateAuthenticationDelete Model)
		//{
		//	Collection = await UnitOfWork.CandidateAuthentication.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	CandidateAuthentication CandidateAuthentication = Collection.SingleOrDefault()!;
		//	await UnitOfWork.CandidateAuthentication.DeleteAsync(CandidateAuthentication);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CandidateAuthenticationResponse>
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CandidateAuthenticationResponse>(CandidateAuthentication)
		//	};
		//}

		//public async Task<ServiceResponse<CandidateAuthenticationResponse>> SelectAsync(CandidateAuthenticationSelect Model)
		//{
		//	return new ServiceResponse<CandidateAuthenticationResponse>
		//	{
		//		ResponseDataSource = Mapper.Map<List<CandidateAuthenticationResponse>>
		//		(await UnitOfWork.CandidateAuthentication.SelectAsync(x => x.IsActive == true))
		//	};
		//}

		//public async Task<ServiceResponse<CandidateAuthenticationResponse>> SelectSingleAsync(CandidateAuthenticationSelectSingle Model)
		//{
		//	return new ServiceResponse<CandidateAuthenticationResponse>
		//	{
		//		ResponseDataSource = Mapper.Map<List<CandidateAuthenticationResponse>>
		//		(await UnitOfWork.CandidateAuthentication.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
		//	};
		//}
	}
}