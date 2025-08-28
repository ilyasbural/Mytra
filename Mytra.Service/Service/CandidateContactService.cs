namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateContactService : ICandidateContactService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateContact> Validator;

		public CandidateContactService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateContact> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<CandidateContactResponse>> InsertAsync(CandidateContactInsert Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateContactResponse>> DeleteAsync(CandidateContactDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateContactResponse>> UpdateAsync(CandidateContactUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateContactResponse>> SelectAsync(CandidateContactSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateContactResponse>> SelectSingleAsync(CandidateContactSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}