namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class LanguageService : ILanguageService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<Language> Validator;

		public LanguageService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Language> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<LanguageResponse>> InsertAsync(LanguageInsert Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<LanguageResponse>> UpdateAsync(LanguageUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<LanguageResponse>> DeleteAsync(LanguageDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<LanguageResponse>> SelectAsync(LanguageSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<LanguageResponse>> SelectSingleAsync(LanguageSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}