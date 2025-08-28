namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class ManagerAuthenticationService : IManagerAuthenticationService
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

		public async Task<ServiceResponse<ManagerAuthenticationResponse>> InsertAsync(ManagerAuthenticationInsert Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<ManagerAuthenticationResponse>> UpdateAsync(ManagerAuthenticationUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<ManagerAuthenticationResponse>> DeleteAsync(ManagerAuthenticationDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<ManagerAuthenticationResponse>> SelectAsync(ManagerAuthenticationSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<ManagerAuthenticationResponse>> SelectSingleAsync(ManagerAuthenticationSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}