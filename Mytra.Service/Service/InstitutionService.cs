namespace Mytra.Service
{
	using Core;
	using Common;
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
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.Institution.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<Institution>.SuccessResult(Data, "Record has been success")
					: DataService<Institution>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<Institution>.FailureResult(ex.Message, "some error");
			}
		}

		//public async Task<ServiceResponse<InstitutionResponse>> UpdateAsync(InstitutionUpdate Model)
		//{
		//	Collection = await UnitOfWork.Institution.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	Institution Institution = Collection.SingleOrDefault()!;
		//	Institution.Name = Model.Name;
		//	await UnitOfWork.Institution.UpdateAsync(Institution);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<InstitutionResponse>
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<InstitutionResponse>(Institution)
		//	};
		//}

		//public async Task<ServiceResponse<InstitutionResponse>> DeleteAsync(InstitutionDelete Model)
		//{
		//	Collection = await UnitOfWork.Institution.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	Institution Institution = Collection.SingleOrDefault()!;
		//	await UnitOfWork.Institution.DeleteAsync(Institution);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<InstitutionResponse>
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<InstitutionResponse>(Institution)
		//	};
		//}

		//public async Task<ServiceResponse<InstitutionResponse>> SelectAsync(InstitutionSelect Model)
		//{
		//	return new ServiceResponse<InstitutionResponse>
		//	{
		//		ResponseDataSource = Mapper.Map<List<InstitutionResponse>>
		//		(await UnitOfWork.Institution.SelectAsync(x => x.IsActive == true))
		//	};
		//}

		//public async Task<ServiceResponse<InstitutionResponse>> SelectSingleAsync(InstitutionSelectSingle Model)
		//{
		//	return new ServiceResponse<InstitutionResponse>
		//	{
		//		ResponseDataSource = Mapper.Map<List<InstitutionResponse>>
		//		(await UnitOfWork.Institution.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
		//	};
		//}
	}
}