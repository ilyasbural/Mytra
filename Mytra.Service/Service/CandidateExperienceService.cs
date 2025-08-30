namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateExperienceService : BusinessObject<CandidateExperience>, ICandidateExperienceService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateExperience> Validator;

		public CandidateExperienceService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateExperience> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<CandidateExperienceResponse>> InsertAsync(CandidateExperienceInsert Model)
		{
			Data = Mapper.Map<CandidateExperience>(Model);
			Data.Id = Guid.NewGuid();
			Data.RegisterDate = DateTime.Now;
			Data.UpdateDate = DateTime.Now;
			Data.IsActive = true;

			Validator.ValidateAndThrow<CandidateExperience>(Data);
			await UnitOfWork.CandidateExperience.InsertAsync(Data);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<CandidateExperienceResponse>()
			{
				Success = Success,
				ResponseData = Mapper.Map<CandidateExperienceResponse>(Data)
			};
		}

		public async Task<ServiceResponse<CandidateExperienceResponse>> UpdateAsync(CandidateExperienceUpdate Model)
		{
			Collection = await UnitOfWork.CandidateExperience.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			CandidateExperience CandidateExperience = Collection.SingleOrDefault()!;
			CandidateExperience.Name = Model.Name;
			await UnitOfWork.CandidateExperience.UpdateAsync(CandidateExperience);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<CandidateExperienceResponse>()
			{
				Success = Success,
				ResponseData = Mapper.Map<CandidateExperienceResponse>(CandidateExperience)
			};
		}

		public async Task<ServiceResponse<CandidateExperienceResponse>> DeleteAsync(CandidateExperienceDelete Model)
		{
			Collection = await UnitOfWork.CandidateExperience.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			CandidateExperience CandidateExperience = Collection.SingleOrDefault()!;
			await UnitOfWork.CandidateExperience.DeleteAsync(CandidateExperience);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<CandidateExperienceResponse>()
			{
				Success = Success,
				ResponseData = Mapper.Map<CandidateExperienceResponse>(CandidateExperience)
			};
		}

		public async Task<ServiceResponse<CandidateExperienceResponse>> SelectAsync(CandidateExperienceSelect Model)
		{
			return new ServiceResponse<CandidateExperienceResponse>()
			{
				ResponseDataSource = Mapper.Map<List<CandidateExperienceResponse>>
				(await UnitOfWork.CandidateExperience.SelectAsync(x => x.IsActive == true))
			};
		}

		public async Task<ServiceResponse<CandidateExperienceResponse>> SelectSingleAsync(CandidateExperienceSelectSingle Model)
		{
			return new ServiceResponse<CandidateExperienceResponse>()
			{
				ResponseDataSource = Mapper.Map<List<CandidateExperienceResponse>>
				(await UnitOfWork.CandidateExperience.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
			};
		}
	}
}