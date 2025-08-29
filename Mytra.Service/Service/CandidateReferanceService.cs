namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateReferanceService : BusinessObject<CandidateReferance>, ICandidateReferanceService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateReferance> Validator;

		public CandidateReferanceService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateReferance> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<CandidateReferanceResponse>> InsertAsync(CandidateReferanceInsert Model)
		{
			Data = Mapper.Map<CandidateReferance>(Model);
			Data.Id = Guid.NewGuid();
			Data.RegisterDate = DateTime.Now;
			Data.UpdateDate = DateTime.Now;
			Data.IsActive = true;

			Validator.ValidateAndThrow<CandidateReferance>(Data);
			await UnitOfWork.CandidateReferance.InsertAsync(Data);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<CandidateReferanceResponse>()
			{
				Success = Success,
				ResponseData = Mapper.Map<CandidateReferanceResponse>(Data)
			};
		}

		public async Task<ServiceResponse<CandidateReferanceResponse>> UpdateAsync(CandidateReferanceUpdate Model)
		{
			return new ServiceResponse<CandidateReferanceResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidateReferanceResponse>> DeleteAsync(CandidateReferanceDelete Model)
		{
			return new ServiceResponse<CandidateReferanceResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidateReferanceResponse>> SelectAsync(CandidateReferanceSelect Model)
		{
			return new ServiceResponse<CandidateReferanceResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidateReferanceResponse>> SelectSingleAsync(CandidateReferanceSelectSingle Model)
		{
			return new ServiceResponse<CandidateReferanceResponse>()
			{

			};
		}
	}
}