namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class ManagerService : IManagerService
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
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<ManagerResponse>> UpdateAsync(ManagerUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<ManagerResponse>> DeleteAsync(ManagerDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<ManagerResponse>> SelectAsync(ManagerSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<ManagerResponse>> SelectSingleAsync(ManagerSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}