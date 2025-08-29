namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateEducationService : ICandidateEducationService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateEducation> Validator;

		public CandidateEducationService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateEducation> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<CandidateEducationResponse>> InsertAsync(CandidateEducationInsert Model)
		{
			return new ServiceResponse<CandidateEducationResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidateEducationResponse>> UpdateAsync(CandidateEducationUpdate Model)
		{
			return new ServiceResponse<CandidateEducationResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidateEducationResponse>> DeleteAsync(CandidateEducationDelete Model)
		{
			return new ServiceResponse<CandidateEducationResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidateEducationResponse>> SelectAsync(CandidateEducationSelect Model)
		{
			return new ServiceResponse<CandidateEducationResponse>()
			{
				//ResponseDataSource = new List<CandidateEducationResponse>()
				//{
				//	new CandidateEducationResponse()
				//	{
				//	}
				//},
				//Success = 1
			};
		}

		public async Task<ServiceResponse<CandidateEducationResponse>> SelectSingleAsync(CandidateEducationSelectSingle Model)
		{
			return new ServiceResponse<CandidateEducationResponse>()
			{
				//ResponseDataSource = new List<CandidateEducationResponse>()
				//{
				//	new CandidateEducationResponse()
				//	{
				//	}
				//},
				//Success = 1
			};
		}
	}
}