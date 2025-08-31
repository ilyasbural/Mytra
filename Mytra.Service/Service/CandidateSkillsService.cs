namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateSkillsService : BusinessObject<CandidateSkills>, ICandidateSkillsService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateSkills> Validator;

		public CandidateSkillsService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateSkills> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		//public async Task<ServiceResponse<CandidateSkillsResponse>> InsertAsync(CandidateSkillsInsert Model)
		//{
		//	Data = Mapper.Map<CandidateSkills>(Model);
		//	Data.Id = Guid.NewGuid();
		//	Data.RegisterDate = DateTime.Now;
		//	Data.UpdateDate = DateTime.Now;
		//	Data.IsActive = true;

		//	Validator.ValidateAndThrow<CandidateSkills>(Data);
		//	await UnitOfWork.CandidateSkills.InsertAsync(Data);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CandidateSkillsResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CandidateSkillsResponse>(Data)
		//	};
		//}

		//public async Task<ServiceResponse<CandidateSkillsResponse>> UpdateAsync(CandidateSkillsUpdate Model)
		//{
		//	Collection = await UnitOfWork.CandidateSkills.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	CandidateSkills CandidateSkills = Collection.SingleOrDefault()!;
		//	CandidateSkills.Name = Model.Name;
		//	await UnitOfWork.CandidateSkills.UpdateAsync(CandidateSkills);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CandidateSkillsResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CandidateSkillsResponse>(CandidateSkills)
		//	};
		//}

		//public async Task<ServiceResponse<CandidateSkillsResponse>> DeleteAsync(CandidateSkillsDelete Model)
		//{
		//	Collection = await UnitOfWork.CandidateSkills.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	CandidateSkills CandidateSkills = Collection.SingleOrDefault()!;
		//	await UnitOfWork.CandidateSkills.DeleteAsync(CandidateSkills);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CandidateSkillsResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CandidateSkillsResponse>(CandidateSkills)
		//	};
		//}

		//public async Task<ServiceResponse<CandidateSkillsResponse>> SelectAsync(CandidateSkillsSelect Model)
		//{
		//	return new ServiceResponse<CandidateSkillsResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<CandidateSkillsResponse>>
		//		(await UnitOfWork.CandidateSkills.SelectAsync(x => x.IsActive == true))
		//	};
		//}

		//public async Task<ServiceResponse<CandidateSkillsResponse>> SelectSingleAsync(CandidateSkillsSelectSingle Model)
		//{
		//	return new ServiceResponse<CandidateSkillsResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<CandidateSkillsResponse>>
		//		(await UnitOfWork.CandidateSkills.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
		//	};
		//}
	}
}