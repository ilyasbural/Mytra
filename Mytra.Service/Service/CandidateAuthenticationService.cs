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
				Success = Success,
				ResponseData = Mapper.Map<CandidateAuthenticationResponse>(Data)
			};
		}

		public async Task<ServiceResponse<CandidateAuthenticationResponse>> UpdateAsync(CandidateAuthenticationUpdate Model)
		{
			Collection = await UnitOfWork.CandidateAuthentication.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			CandidateAuthentication CandidateAuthentication = Collection.SingleOrDefault()!;
			CandidateAuthentication.Name = Model.Name;
			await UnitOfWork.CandidateAuthentication.UpdateAsync(CandidateAuthentication);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<CandidateAuthenticationResponse>
			{
				Success = Success,
				ResponseData = Mapper.Map<CandidateAuthenticationResponse>(CandidateAuthentication)
			};
		}

		public async Task<ServiceResponse<CandidateAuthenticationResponse>> DeleteAsync(CandidateAuthenticationDelete Model)
		{
			Collection = await UnitOfWork.CandidateAuthentication.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			CandidateAuthentication CandidateAuthentication = Collection.SingleOrDefault()!;
			await UnitOfWork.CandidateAuthentication.DeleteAsync(CandidateAuthentication);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<CandidateAuthenticationResponse>
			{
				Success = Success,
				ResponseData = Mapper.Map<CandidateAuthenticationResponse>(CandidateAuthentication)
			};
		}

		public async Task<ServiceResponse<CandidateAuthenticationResponse>> SelectAsync(CandidateAuthenticationSelect Model)
		{
			return new ServiceResponse<CandidateAuthenticationResponse>
			{
				ResponseDataSource = Mapper.Map<List<CandidateAuthenticationResponse>>
				(await UnitOfWork.CandidateAuthentication.SelectAsync(x => x.IsActive == true))
			};
		}

		public async Task<ServiceResponse<CandidateAuthenticationResponse>> SelectSingleAsync(CandidateAuthenticationSelectSingle Model)
		{
			return new ServiceResponse<CandidateAuthenticationResponse>
			{
				ResponseDataSource = Mapper.Map<List<CandidateAuthenticationResponse>>
				(await UnitOfWork.CandidateAuthentication.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
			};
		}
	}
}