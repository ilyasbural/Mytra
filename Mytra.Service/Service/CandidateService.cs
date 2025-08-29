namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateService : BusinessObject<Candidate>, ICandidateService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<Candidate> Validator;

		public CandidateService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Candidate> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<CandidateResponse>> InsertAsync(CandidateInsert Model)
		{
			Data = Mapper.Map<Candidate>(Model);
			Data.Id = Guid.NewGuid();
			Data.RegisterDate = DateTime.Now;
			Data.UpdateDate = DateTime.Now;
			Data.IsActive = true;

			Validator.ValidateAndThrow<Candidate>(Data);
			await UnitOfWork.Candidate.InsertAsync(Data);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<CandidateResponse>()
			{
				Success = Success,
				ResponseData = Mapper.Map<CandidateResponse>(Data)
			};
		}

		public async Task<ServiceResponse<CandidateResponse>> UpdateAsync(CandidateUpdate Model)
		{
			return new ServiceResponse<CandidateResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidateResponse>> DeleteAsync(CandidateDelete Model)
		{
			return new ServiceResponse<CandidateResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidateResponse>> SelectAsync(CandidateSelect Model)
		{
			return new ServiceResponse<CandidateResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidateResponse>> SelectSingleAsync(CandidateSelectSingle Model)
		{
			return new ServiceResponse<CandidateResponse>()
			{

			};
		}
	}
}