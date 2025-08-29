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
			return new ServiceResponse<ManagerAuthenticationResponse>()
			{

			};
		}

		public async Task<ServiceResponse<ManagerAuthenticationResponse>> UpdateAsync(ManagerAuthenticationUpdate Model)
		{
			return new ServiceResponse<ManagerAuthenticationResponse>()
			{

			};
		}

		public async Task<ServiceResponse<ManagerAuthenticationResponse>> DeleteAsync(ManagerAuthenticationDelete Model)
		{
			return new ServiceResponse<ManagerAuthenticationResponse>()
			{

			};
		}

		public async Task<ServiceResponse<ManagerAuthenticationResponse>> SelectAsync(ManagerAuthenticationSelect Model)
		{
			return new ServiceResponse<ManagerAuthenticationResponse>()
			{

			};
		}

		public async Task<ServiceResponse<ManagerAuthenticationResponse>> SelectSingleAsync(ManagerAuthenticationSelectSingle Model)
		{
			return new ServiceResponse<ManagerAuthenticationResponse>()
			{

			};
		}
	}
}