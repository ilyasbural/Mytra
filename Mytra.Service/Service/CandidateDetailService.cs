namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CandidateDetailService : BusinessObject<CandidateDetail>, ICandidateDetailService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<CandidateDetail> Validator;

		public CandidateDetailService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<CandidateDetail> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<CandidateDetailResponse>> InsertAsync(CandidateDetailInsert Model)
		{
			Data = Mapper.Map<CandidateDetail>(Model);
			Data.Id = Guid.NewGuid();
			Data.RegisterDate = DateTime.Now;
			Data.UpdateDate = DateTime.Now;
			Data.IsActive = true;

			Validator.ValidateAndThrow<CandidateDetail>(Data);
			await UnitOfWork.CandidateDetail.InsertAsync(Data);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<CandidateDetailResponse>()
			{
				Success = Success,
				ResponseData = Mapper.Map<CandidateDetailResponse>(Data)
			};
		}

		public async Task<ServiceResponse<CandidateDetailResponse>> UpdateAsync(CandidateDetailUpdate Model)
		{
			Collection = await UnitOfWork.CandidateDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			CandidateDetail CandidateDetail = Collection.SingleOrDefault()!;
			CandidateDetail.Name = Model.Name;
			await UnitOfWork.CandidateDetail.UpdateAsync(CandidateDetail);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<CandidateDetailResponse>()
			{
				Success = Success,
				ResponseData = Mapper.Map<CandidateDetailResponse>(CandidateDetail)
			};
		}

		public async Task<ServiceResponse<CandidateDetailResponse>> DeleteAsync(CandidateDetailDelete Model)
		{
			Collection = await UnitOfWork.CandidateDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			CandidateDetail CandidateDetail = Collection.SingleOrDefault()!;
			await UnitOfWork.CandidateDetail.DeleteAsync(CandidateDetail);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<CandidateDetailResponse>()
			{
				Success = Success,
				ResponseData = Mapper.Map<CandidateDetailResponse>(CandidateDetail)
			};
		}

		public async Task<ServiceResponse<CandidateDetailResponse>> SelectAsync(CandidateDetailSelect Model)
		{
			return new ServiceResponse<CandidateDetailResponse>()
			{

			};
		}

		public async Task<ServiceResponse<CandidateDetailResponse>> SelectSingleAsync(CandidateDetailSelectSingle Model)
		{
			return new ServiceResponse<CandidateDetailResponse>()
			{

			};
		}
	}
}