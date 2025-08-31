namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CollegeService : BusinessObject<College>, ICollegeService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<College> Validator;

		public CollegeService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<College> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<College>> InsertAsync(CollegeInsert Model)
		{
			try
			{
				Data = Mapper.Map<College>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<College>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.College.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<College>.SuccessResult(Data, "Record has been success")
					: DataService<College>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<College>.FailureResult(ex.Message, "some error");
			}
		}

		//public async Task<ServiceResponse<CollegeResponse>> UpdateAsync(CollegeUpdate Model)
		//{
		//	Collection = await UnitOfWork.College.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	College College = Collection.SingleOrDefault()!;
		//	College.Name = Model.Name;
		//	await UnitOfWork.College.UpdateAsync(College);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CollegeResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CollegeResponse>(College)
		//	};
		//}

		//public async Task<ServiceResponse<CollegeResponse>> DeleteAsync(CollegeDelete Model)
		//{
		//	Collection = await UnitOfWork.College.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	College College = Collection.SingleOrDefault()!;
		//	await UnitOfWork.College.DeleteAsync(College);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CollegeResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CollegeResponse>(College)
		//	};
		//}

		//public async Task<ServiceResponse<CollegeResponse>> SelectAsync(CollegeSelect Model)
		//{
		//	return new ServiceResponse<CollegeResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<CollegeResponse>>
		//		(await UnitOfWork.College.SelectAsync(x => x.IsActive == true))
		//	};
		//}

		//public async Task<ServiceResponse<CollegeResponse>> SelectSingleAsync(CollegeSelectSingle Model)
		//{
		//	return new ServiceResponse<CollegeResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<CollegeResponse>>
		//		(await UnitOfWork.College.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
		//	};
		//}
	}
}