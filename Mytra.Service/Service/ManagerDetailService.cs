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
			return new ServiceResponse<ManagerDetailResponse>()
			{

			};
		}

		public async Task<ServiceResponse<ManagerDetailResponse>> UpdateAsync(ManagerDetailUpdate Model)
		{
			return new ServiceResponse<ManagerDetailResponse>()
			{

			};
		}

		public async Task<ServiceResponse<ManagerDetailResponse>> DeleteAsync(ManagerDetailDelete Model)
		{
			return new ServiceResponse<ManagerDetailResponse>()
			{

			};
		}

		public async Task<ServiceResponse<ManagerDetailResponse>> SelectAsync(ManagerDetailSelect Model)
		{
			return new ServiceResponse<ManagerDetailResponse>()
			{

			};
		}

		public async Task<ServiceResponse<ManagerDetailResponse>> SelectSingleAsync(ManagerDetailSelectSingle Model)
		{
			return new ServiceResponse<ManagerDetailResponse>()
			{

			};
		}
	}
}