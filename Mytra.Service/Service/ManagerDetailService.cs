namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class ManagerDetailService : BusinessObject<ManagerDetail>, IManagerDetailService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<ManagerDetail> Validator;

		public ManagerDetailService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<ManagerDetail> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<ManagerDetailResponse>> InsertAsync(ManagerDetailInsert Model)
		{
			Data = Mapper.Map<ManagerDetail>(Model);
			Data.Id = Guid.NewGuid();
			Data.RegisterDate = DateTime.Now;
			Data.UpdateDate = DateTime.Now;
			Data.IsActive = true;

			Validator.ValidateAndThrow<ManagerDetail>(Data);
			await UnitOfWork.ManagerDetail.InsertAsync(Data);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<ManagerDetailResponse>()
			{
				Success = Success,
				ResponseData = Mapper.Map<ManagerDetailResponse>(Data)
			};
		}

		public async Task<ServiceResponse<ManagerDetailResponse>> UpdateAsync(ManagerDetailUpdate Model)
		{
			Collection = await UnitOfWork.ManagerDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			ManagerDetail ManagerDetail = Collection.SingleOrDefault()!;
			ManagerDetail.Name = Model.Name;
			await UnitOfWork.ManagerDetail.UpdateAsync(ManagerDetail);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<ManagerDetailResponse>()
			{
				Success = Success,
				ResponseData = Mapper.Map<ManagerDetailResponse>(ManagerDetail)
			};
		}

		public async Task<ServiceResponse<ManagerDetailResponse>> DeleteAsync(ManagerDetailDelete Model)
		{
			Collection = await UnitOfWork.ManagerDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			ManagerDetail ManagerDetail = Collection.SingleOrDefault()!;
			await UnitOfWork.ManagerDetail.DeleteAsync(ManagerDetail);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<ManagerDetailResponse>()
			{
				Success = Success,
				ResponseData = Mapper.Map<ManagerDetailResponse>(ManagerDetail)
			};
		}

		public async Task<ServiceResponse<ManagerDetailResponse>> SelectAsync(ManagerDetailSelect Model)
		{
			return new ServiceResponse<ManagerDetailResponse>()
			{
				ResponseDataSource = Mapper.Map<List<ManagerDetailResponse>>
				(await UnitOfWork.ManagerDetail.SelectAsync(x => x.IsActive == true))
			};
		}

		public async Task<ServiceResponse<ManagerDetailResponse>> SelectSingleAsync(ManagerDetailSelectSingle Model)
		{
			return new ServiceResponse<ManagerDetailResponse>()
			{
				ResponseDataSource = Mapper.Map<List<ManagerDetailResponse>>
				(await UnitOfWork.ManagerDetail.SelectAsync(x => x.IsActive == true))
			};
		}
	}
}