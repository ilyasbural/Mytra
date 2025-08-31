namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class ManagerAuthenticationService : BusinessObject<ManagerAuthentication>, IManagerAuthenticationService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<ManagerAuthentication> Validator;

		public ManagerAuthenticationService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ManagerAuthentication> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<ManagerAuthentication>> InsertAsync(ManagerAuthenticationInsert Model)
		{
			try
			{
				Data = Mapper.Map<ManagerAuthentication>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<ManagerAuthentication>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.ManagerAuthentication.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<ManagerAuthentication>.SuccessResult(Data, "Record has been success")
					: DataService<ManagerAuthentication>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<ManagerAuthentication>.FailureResult(ex.Message, "some error");
			}
		}

		//public async Task<ServiceResponse<ManagerAuthenticationResponse>> UpdateAsync(ManagerAuthenticationUpdate Model)
		//{
		//	Collection = await UnitOfWork.ManagerAuthentication.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	ManagerAuthentication ManagerAuthentication = Collection.SingleOrDefault()!;
		//	ManagerAuthentication.Name = Model.Name;
		//	await UnitOfWork.ManagerAuthentication.UpdateAsync(ManagerAuthentication);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<ManagerAuthenticationResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<ManagerAuthenticationResponse>(ManagerAuthentication)
		//	};
		//}

		//public async Task<ServiceResponse<ManagerAuthenticationResponse>> DeleteAsync(ManagerAuthenticationDelete Model)
		//{
		//	Collection = await UnitOfWork.ManagerAuthentication.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	ManagerAuthentication ManagerAuthentication = Collection.SingleOrDefault()!;
		//	await UnitOfWork.ManagerAuthentication.DeleteAsync(ManagerAuthentication);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<ManagerAuthenticationResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<ManagerAuthenticationResponse>(ManagerAuthentication)
		//	};
		//}

		//public async Task<ServiceResponse<ManagerAuthenticationResponse>> SelectAsync(ManagerAuthenticationSelect Model)
		//{
		//	return new ServiceResponse<ManagerAuthenticationResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<ManagerAuthenticationResponse>>
		//		(await UnitOfWork.ManagerAuthentication.SelectAsync(x => x.IsActive == true))
		//	};
		//}

		//public async Task<ServiceResponse<ManagerAuthenticationResponse>> SelectSingleAsync(ManagerAuthenticationSelectSingle Model)
		//{
		//	return new ServiceResponse<ManagerAuthenticationResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<ManagerAuthenticationResponse>>
		//		(await UnitOfWork.ManagerAuthentication.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
		//	};
		//}
	}
}