namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class InstitutionService : IInstitutionService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<Institution> Validator;

		public InstitutionService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Institution> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<InstitutionResponse>> InsertAsync(InstitutionInsert Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<InstitutionResponse>> UpdateAsync(InstitutionUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<InstitutionResponse>> DeleteAsync(InstitutionDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<InstitutionResponse>> SelectAsync(InstitutionSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<InstitutionResponse>> SelectSingleAsync(InstitutionSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}