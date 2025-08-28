namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidatePhotoService : ICandidatePhotoService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidatePhoto> Validator;

		public CandidatePhotoService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidatePhoto> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<CandidatePhotoResponse>> InsertAsync(CandidatePhotoInsert Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidatePhotoResponse>> UpdateAsync(CandidatePhotoUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidatePhotoResponse>> DeleteAsync(CandidatePhotoDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidatePhotoResponse>> SelectAsync(CandidatePhotoSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CandidatePhotoResponse>> SelectSingleAsync(CandidatePhotoSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}