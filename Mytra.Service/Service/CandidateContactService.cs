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

		//public async Task<ServiceResponse<CandidateContactResponse>> InsertAsync(CandidateContactInsert Model)
		//{
		//	Data = Mapper.Map<CandidateContact>(Model);
		//	Data.Id = Guid.NewGuid();
		//	Data.RegisterDate = DateTime.Now;
		//	Data.UpdateDate = DateTime.Now;
		//	Data.IsActive = true;

		//	Validator.ValidateAndThrow<CandidateContact>(Data);
		//	await UnitOfWork.CandidateContact.InsertAsync(Data);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CandidateContactResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CandidateContactResponse>(Data),
		//	};
		//}

		//public async Task<ServiceResponse<CandidateContactResponse>> UpdateAsync(CandidateContactUpdate Model)
		//{
		//	Collection = await UnitOfWork.CandidateContact.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	CandidateContact CandidateContact = Collection.SingleOrDefault()!;
		//	CandidateContact.Name = Model.Name;
		//	await UnitOfWork.CandidateContact.UpdateAsync(CandidateContact);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CandidateContactResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CandidateContactResponse>(CandidateContact)
		//	};
		//}

		//public async Task<ServiceResponse<CandidateContactResponse>> DeleteAsync(CandidateContactDelete Model)
		//{
		//	Collection = await UnitOfWork.CandidateContact.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	CandidateContact CandidateContact = Collection.SingleOrDefault()!;
		//	await UnitOfWork.CandidateContact.DeleteAsync(CandidateContact);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<CandidateContactResponse>()
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<CandidateContactResponse>(CandidateContact)
		//	};
		//}

		//public async Task<ServiceResponse<CandidateContactResponse>> SelectAsync(CandidateContactSelect Model)
		//{
		//	return new ServiceResponse<CandidateContactResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<CandidateContactResponse>>
		//		(await UnitOfWork.CandidateContact.SelectAsync(x => x.IsActive == true))
		//	};
		//}

		//public async Task<ServiceResponse<CandidateContactResponse>> SelectSingleAsync(CandidateContactSelectSingle Model)
		//{
		//	return new ServiceResponse<CandidateContactResponse>()
		//	{
		//		ResponseDataSource = Mapper.Map<List<CandidateContactResponse>>
		//		(await UnitOfWork.CandidateContact.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
		//	};
		//}
	}
}