namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateAuthenticationService : BusinessObject<CandidateAuthentication>, ICandidateAuthenticationService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateAuthentication> Validator;

		public CandidateAuthenticationService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateAuthentication> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<CandidateAuthenticationResponse>> InsertAsync(CandidateAuthenticationInsert Model)
		{
			Data = Mapper.Map<CandidateAuthentication>(Model);
			Data.Id = Guid.NewGuid();
			Data.RegisterDate = DateTime.Now;
			Data.UpdateDate = DateTime.Now;
			Data.IsActive = true;

			Validator.ValidateAndThrow<CandidateAuthentication>(Data);
			await UnitOfWork.CandidateAuthentication.InsertAsync(Data);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<CandidateAuthenticationResponse>
			{
				ResponseData = Mapper.Map<CandidateAuthenticationResponse>(Data),
				Success = Success
			};
		}

		public async Task<ServiceResponse<CandidateAuthenticationResponse>> UpdateAsync(CandidateAuthenticationUpdate Model)
		{
			return new ServiceResponse<CandidateAuthenticationResponse>
			{

			};
		}

		public async Task<ServiceResponse<CandidateAuthenticationResponse>> DeleteAsync(CandidateAuthenticationDelete Model)
		{
			return new ServiceResponse<CandidateAuthenticationResponse>
			{

			};
		}

		public async Task<ServiceResponse<CandidateAuthenticationResponse>> SelectAsync(CandidateAuthenticationSelect Model)
		{
			return new ServiceResponse<CandidateAuthenticationResponse>
			{

			};
		}

		public async Task<ServiceResponse<CandidateAuthenticationResponse>> SelectSingleAsync(CandidateAuthenticationSelectSingle Model)
		{
			return new ServiceResponse<CandidateAuthenticationResponse>
			{

			};
		}
	}
}