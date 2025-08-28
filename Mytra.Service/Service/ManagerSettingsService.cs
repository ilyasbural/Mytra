namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class ManagerSettingsService : IManagerSettingsService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<ManagerSettings> Validator;

		public ManagerSettingsService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ManagerSettings> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<ManagerSettingsResponse>> InsertAsync(ManagerSettingsInsert Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<ManagerSettingsResponse>> UpdateAsync(ManagerSettingsUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<ManagerSettingsResponse>> DeleteAsync(ManagerSettingsDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<ManagerSettingsResponse>> SelectAsync(ManagerSettingsSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<ManagerSettingsResponse>> SelectSingleAsync(ManagerSettingsSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}