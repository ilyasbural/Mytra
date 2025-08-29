namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateContactService : BusinessObject<CandidateContact>, ICandidateContactService
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
			Data = Mapper.Map<CandidateContact>(Model);
			Data.Id = Guid.NewGuid();
			Data.RegisterDate = DateTime.Now;
			Data.UpdateDate = DateTime.Now;
			Data.IsActive = true;

			Validator.ValidateAndThrow<CandidateContact>(Data);
			await UnitOfWork.CandidateContact.InsertAsync(Data);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<CandidateContactResponse>()
			{
				Success = Success,
				ResponseData = Mapper.Map<CandidateContactResponse>(Data),
			};
		}

		public async Task<ServiceResponse<CandidateContactResponse>> DeleteAsync(CandidateContactDelete Model)
		{
			return new ServiceResponse<CandidateContactResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidateContactResponse>> UpdateAsync(CandidateContactUpdate Model)
		{
			return new ServiceResponse<CandidateContactResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidateContactResponse>> SelectAsync(CandidateContactSelect Model)
		{
			return new ServiceResponse<CandidateContactResponse>()
			{
				//ResponseDataSource = new List<CandidateContactResponse>()
				//{
				//	new CandidateContactResponse()
				//	{
				//	}
				//},
				//Success = 1
			};
		}

		public async Task<ServiceResponse<CandidateContactResponse>> SelectSingleAsync(CandidateContactSelectSingle Model)
		{
			return new ServiceResponse<CandidateContactResponse>()
			{
				//ResponseDataSource = new List<CandidateContactResponse>()
				//{
				//	new CandidateContactResponse()
				//	{
				//	}
				//},
				//Success = 1
			};
		}
	}
}