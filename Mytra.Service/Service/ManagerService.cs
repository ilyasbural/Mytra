namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class ManagerService : BusinessObject<Manager>, IManagerService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<Manager> Validator;

		public ManagerService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Manager> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<Manager>> InsertAsync(ManagerInsert Model)
		{
			try
			{
				Data = Mapper.Map<Manager>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<Manager>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.Manager.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<Manager>.SuccessResult(Data, "Record has been success")
					: DataService<Manager>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<Manager>.FailureResult(ex.Message, "some error");
			}
		}

		//public async Task<ServiceResponse<ManagerResponse>> UpdateAsync(ManagerUpdate Model)
		//{
		//	Collection = await UnitOfWork.Manager.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	Manager Manager = Collection.SingleOrDefault()!;
		//	Manager.Name = Model.Name;
		//	await UnitOfWork.Manager.UpdateAsync(Manager);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<ManagerResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<ManagerResponse>(Manager)
		//	};
		//}

		//public async Task<ServiceResponse<ManagerResponse>> DeleteAsync(ManagerDelete Model)
		//{
		//	Collection = await UnitOfWork.Manager.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	Manager Manager = Collection.SingleOrDefault()!;
		//	await UnitOfWork.Manager.DeleteAsync(Manager);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<ManagerResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<ManagerResponse>(Manager)
		//	};
		//}

		//public async Task<ServiceResponse<ManagerResponse>> SelectAsync(ManagerSelect Model)
		//{
		//	return new ServiceResponse<ManagerResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<ManagerResponse>>
		//		(await UnitOfWork.Manager.SelectAsync(x => x.IsActive == true))
		//	};
		//}

		//public async Task<ServiceResponse<ManagerResponse>> SelectSingleAsync(ManagerSelectSingle Model)
		//{
		//	return new ServiceResponse<ManagerResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<ManagerResponse>>
		//		(await UnitOfWork.Manager.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
		//	};
		//}
	}
}