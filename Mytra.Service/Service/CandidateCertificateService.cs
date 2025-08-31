namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateCertificateService : BusinessObject<CandidateCertificate>, ICandidateCertificateService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateCertificate> Validator;

		public CandidateCertificateService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateCertificate> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public Task<DataService<CandidateCertificate>> DeleteAsync(CandidateCertificateDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<DataService<CandidateCertificate>> InsertAsync(CandidateCertificateInsert Model)
		{
			try
			{
				Data = Mapper.Map<CandidateCertificate>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<CandidateCertificate>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.CandidateCertificate.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<CandidateCertificate>.SuccessResult(Data, "Record has been success")
					: DataService<CandidateCertificate>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<CandidateCertificate>.FailureResult(ex.Message, "some error");
			}
		}

		public Task<DataService<CandidateCertificate>> SelectAsync(CandidateCertificateSelect Model)
		{
			throw new NotImplementedException();
		}

		public Task<DataService<CandidateCertificate>> SelectSingleAsync(CandidateCertificateSelectSingle Model)
		{
			throw new NotImplementedException();
		}

		public Task<DataService<CandidateCertificate>> UpdateAsync(CandidateCertificateUpdate Model)
		{
			throw new NotImplementedException();
		}

		//public async Task<ServiceResponse<CandidateCertificateResponse>> UpdateAsync(CandidateCertificateUpdate Model)
		//{
		//	Collection = await UnitOfWork.CandidateCertificate.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	CandidateCertificate CandidateCertificate = Collection.SingleOrDefault()!;
		//	CandidateCertificate.Name = Model.Name;
		//	await UnitOfWork.CandidateCertificate.UpdateAsync(CandidateCertificate);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CandidateCertificateResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CandidateCertificateResponse>(CandidateCertificate)
		//	};
		//}

		//public async Task<ServiceResponse<CandidateCertificateResponse>> DeleteAsync(CandidateCertificateDelete Model)
		//{
		//	Collection = await UnitOfWork.CandidateCertificate.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	CandidateCertificate CandidateCertificate = Collection.SingleOrDefault()!;
		//	await UnitOfWork.CandidateCertificate.DeleteAsync(CandidateCertificate);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CandidateCertificateResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CandidateCertificateResponse>(CandidateCertificate)
		//	};
		//}

		//public async Task<ServiceResponse<CandidateCertificateResponse>> SelectAsync(CandidateCertificateSelect Model)
		//{
		//	return new ServiceResponse<CandidateCertificateResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<CandidateCertificateResponse>>
		//		(await UnitOfWork.CandidateCertificate.SelectAsync(x => x.IsActive == true))
		//	};
		//}

		//public async Task<ServiceResponse<CandidateCertificateResponse>> SelectSingleAsync(CandidateCertificateSelectSingle Model)
		//{
		//	return new ServiceResponse<CandidateCertificateResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<CandidateCertificateResponse>>
		//		(await UnitOfWork.CandidateCertificate.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
		//	};
		//}
	}
}