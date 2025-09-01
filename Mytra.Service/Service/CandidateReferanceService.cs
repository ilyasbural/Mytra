namespace Mytra.Service
{
	using Core;
	using Common;
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

		public async Task<DataService<CandidateReferance>> DeleteAsync(CandidateReferanceDelete Model)
		{
			throw new NotImplementedException();
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
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.CandidateReferance.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<CandidateReferance>.SuccessResult(Data, "Record has been success")
					: DataService<CandidateReferance>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<CandidateReferance>.FailureResult(ex.Message, "some error");
			}
		}

		public async Task<DataService<CandidateReferance>> SelectAsync(CandidateReferanceSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<DataService<CandidateReferance>> SelectSingleAsync(CandidateReferanceSelectSingle Model)
		{
			throw new NotImplementedException();
		}

		public async Task<DataService<CandidateReferance>> UpdateAsync(CandidateReferanceUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateReferance.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null)
					return DataService<CandidateReferance>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				//Data = Mapper.Map(model, Data);
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.CandidateReferance.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateReferance>.SuccessResult(Data, "Kayıt güncellendi")
					: DataService<CandidateReferance>.FailureResult("Kayıt güncellenemedi");
			}
			catch (Exception ex)
			{
				return DataService<CandidateReferance>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		//public async Task<ServiceResponse<CandidateReferanceResponse>> UpdateAsync(CandidateReferanceUpdate Model)
		//{
		//	Collection = await UnitOfWork.CandidateReferance.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	CandidateReferance CandidateReferance = Collection.SingleOrDefault()!;
		//	CandidateReferance.Name = Model.Name;
		//	await UnitOfWork.CandidateReferance.UpdateAsync(CandidateReferance);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CandidateReferanceResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CandidateReferanceResponse>(CandidateReferance)
		//	};
		//}

		//public async Task<ServiceResponse<CandidateReferanceResponse>> DeleteAsync(CandidateReferanceDelete Model)
		//{
		//	Collection = await UnitOfWork.CandidateReferance.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	CandidateReferance CandidateReferance = Collection.SingleOrDefault()!;
		//	await UnitOfWork.CandidateReferance.DeleteAsync(CandidateReferance);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CandidateReferanceResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CandidateReferanceResponse>(CandidateReferance)
		//	};
		//}

		//public async Task<ServiceResponse<CandidateReferanceResponse>> SelectAsync(CandidateReferanceSelect Model)
		//{
		//	return new ServiceResponse<CandidateReferanceResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<CandidateReferanceResponse>>
		//		(await UnitOfWork.CandidateReferance.SelectAsync(x => x.IsActive == true))
		//	};
		//}

		//public async Task<ServiceResponse<CandidateReferanceResponse>> SelectSingleAsync(CandidateReferanceSelectSingle Model)
		//{
		//	return new ServiceResponse<CandidateReferanceResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<CandidateReferanceResponse>>
		//		(await UnitOfWork.CandidateReferance.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
		//	};
		//}
	}
}