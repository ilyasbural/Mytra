namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateEducationService : BusinessObject<CandidateEducation>, ICandidateEducationService
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

		//public async Task<ServiceResponse<CandidateEducationResponse>> InsertAsync(CandidateEducationInsert Model)
		//{
		//	Data = Mapper.Map<CandidateEducation>(Model);
		//	Data.Id = Guid.NewGuid();
		//	Data.RegisterDate = DateTime.Now;
		//	Data.UpdateDate = DateTime.Now;
		//	Data.IsActive = true;

		//	Validator.ValidateAndThrow<CandidateEducation>(Data);
		//	await UnitOfWork.CandidateEducation.InsertAsync(Data);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CandidateEducationResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CandidateEducationResponse>(Data)
		//	};
		//}

		//public async Task<ServiceResponse<CandidateEducationResponse>> UpdateAsync(CandidateEducationUpdate Model)
		//{
		//	Collection = await UnitOfWork.CandidateEducation.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	CandidateEducation CandidateEducation = Collection.SingleOrDefault()!;
		//	CandidateEducation.Name = Model.Name;
		//	await UnitOfWork.CandidateEducation.UpdateAsync(CandidateEducation);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CandidateEducationResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CandidateEducationResponse>(CandidateEducation)
		//	};
		//}

		//public async Task<ServiceResponse<CandidateEducationResponse>> DeleteAsync(CandidateEducationDelete Model)
		//{
		//	Collection = await UnitOfWork.CandidateEducation.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	CandidateEducation CandidateEducation = Collection.SingleOrDefault()!;
		//	await UnitOfWork.CandidateEducation.DeleteAsync(CandidateEducation);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CandidateEducationResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CandidateEducationResponse>(CandidateEducation)
		//	};
		//}

		//public async Task<ServiceResponse<CandidateEducationResponse>> SelectAsync(CandidateEducationSelect Model)
		//{
		//	return new ServiceResponse<CandidateEducationResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<CandidateEducationResponse>>
		//		(await UnitOfWork.CandidateEducation.SelectAsync(x => x.IsActive == true))
		//	};
		//}

		//public async Task<ServiceResponse<CandidateEducationResponse>> SelectSingleAsync(CandidateEducationSelectSingle Model)
		//{
		//	return new ServiceResponse<CandidateEducationResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<CandidateEducationResponse>>
		//		(await UnitOfWork.CandidateEducation.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
		//	};
		//}
	}
}