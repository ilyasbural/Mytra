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

		public async Task<ServiceResponse<ManagerResponse>> InsertAsync(ManagerInsert Model)
		{
			Data = Mapper.Map<Manager>(Model);
			Data.Id = Guid.NewGuid();
			Data.RegisterDate = DateTime.Now;
			Data.UpdateDate = DateTime.Now;
			Data.IsActive = true;

			Validator.ValidateAndThrow<Manager>(Data);
			await UnitOfWork.Manager.InsertAsync(Data);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<ManagerResponse>()
			{
				Success = Success,
				ResponseData = Mapper.Map<ManagerResponse>(Data)
			};
		}

		public async Task<ServiceResponse<ManagerResponse>> UpdateAsync(ManagerUpdate Model)
		{
			Collection = await UnitOfWork.Manager.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			Manager Manager = Collection.SingleOrDefault()!;
			Manager.Name = Model.Name;
			await UnitOfWork.Manager.UpdateAsync(Manager);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<ManagerResponse>()
			{
				Success = Success,
				ResponseData = Mapper.Map<ManagerResponse>(Manager)
			};
		}

		public async Task<ServiceResponse<ManagerResponse>> DeleteAsync(ManagerDelete Model)
		{
			Collection = await UnitOfWork.Manager.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			Manager Manager = Collection.SingleOrDefault()!;
			await UnitOfWork.Manager.DeleteAsync(Manager);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<ManagerResponse>()
			{
				Success = Success,
				ResponseData = Mapper.Map<ManagerResponse>(Manager)
			};
		}

		public async Task<ServiceResponse<ManagerResponse>> SelectAsync(ManagerSelect Model)
		{
			return new ServiceResponse<ManagerResponse>()
			{

			};
		}

		public async Task<ServiceResponse<ManagerResponse>> SelectSingleAsync(ManagerSelectSingle Model)
		{
			return new ServiceResponse<ManagerResponse>()
			{

			};
		}
	}
}