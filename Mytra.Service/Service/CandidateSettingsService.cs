namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateSettingsService : ICandidateSettingsService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateSettings> Validator;

		public CandidateSettingsService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateSettings> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<CandidateSettingsResponse>> InsertAsync(CandidateSettingsInsert Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateSettingsResponse>> UpdateAsync(CandidateSettingsUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateSettingsResponse>> DeleteAsync(CandidateSettingsDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateSettingsResponse>> SelectAsync(CandidateSettingsSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidateSettingsResponse>> SelectSingleAsync(CandidateSettingsSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}