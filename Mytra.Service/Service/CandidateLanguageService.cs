namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateLanguageService : ICandidateLanguageService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateLanguage> Validator;

		public CandidateLanguageService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateLanguage> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<CandidateLanguageResponse>> InsertAsync(CandidateLanguageInsert Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateLanguageResponse>> UpdateAsync(CandidateLanguageUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateLanguageResponse>> DeleteAsync(CandidateLanguageDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateLanguageResponse>> SelectAsync(CandidateLanguageSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateLanguageResponse>> SelectSingleAsync(CandidateLanguageSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}