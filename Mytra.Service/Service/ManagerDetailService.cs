namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class ManagerDetailService : IManagerDetailService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<ManagerDetail> Validator;

		public ManagerDetailService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ManagerDetail> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}
		public async Task<ServiceResponse<ManagerDetailResponse>> InsertAsync(ManagerDetailInsert Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<ManagerDetailResponse>> UpdateAsync(ManagerDetailUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<ManagerDetailResponse>> DeleteAsync(ManagerDetailDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<ManagerDetailResponse>> SelectAsync(ManagerDetailSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<ManagerDetailResponse>> SelectSingleAsync(ManagerDetailSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}