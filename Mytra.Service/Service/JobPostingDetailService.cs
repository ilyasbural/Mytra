namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class JobPostingDetailService : BusinessObject<JobPostingDetail>, IJobPostingDetailService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<JobPostingDetail> Validator;

		public JobPostingDetailService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<JobPostingDetail> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<JobPostingDetail>> DeleteAsync(JobPostingDetailDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<DataService<JobPostingDetail>> InsertAsync(JobPostingDetailInsert Model)
		{
			try
			{
				Data = Mapper.Map<JobPostingDetail>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<JobPostingDetail>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.JobPostingDetail.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<JobPostingDetail>.SuccessResult(Data, "Record has been success")
					: DataService<JobPostingDetail>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<JobPostingDetail>.FailureResult(ex.Message, "some error");
			}
		}

		public async Task<DataService<JobPostingDetail>> SelectAsync(JobPostingDetailSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<DataService<JobPostingDetail>> SelectSingleAsync(JobPostingDetailSelectSingle Model)
		{
			throw new NotImplementedException();
		}

		public async Task<DataService<JobPostingDetail>> UpdateAsync(JobPostingDetailUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.Candidate.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null)
					return DataService<Candidate>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				//Data = Mapper.Map(model, Data);
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.Candidate.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<Candidate>.SuccessResult(Data, "Kayıt güncellendi")
					: DataService<Candidate>.FailureResult("Kayıt güncellenemedi");
			}
			catch (Exception ex)
			{
				return DataService<Candidate>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

		//public async Task<ServiceResponse<JobPostingDetailResponse>> UpdateAsync(JobPostingDetailUpdate Model)
		//{
		//	Collection = await UnitOfWork.JobPostingDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	JobPostingDetail JobPostingDetail = Collection.SingleOrDefault()!;
		//	JobPostingDetail.Name = Model.Name;
		//	await UnitOfWork.JobPostingDetail.UpdateAsync(JobPostingDetail);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<JobPostingDetailResponse>
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<JobPostingDetailResponse>(JobPostingDetail)
		//	};
		//}

		//public async Task<ServiceResponse<JobPostingDetailResponse>> DeleteAsync(JobPostingDetailDelete Model)
		//{
		//	Collection = await UnitOfWork.JobPostingDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	JobPostingDetail JobPostingDetail = Collection.SingleOrDefault()!;
		//	await UnitOfWork.JobPostingDetail.DeleteAsync(JobPostingDetail);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<JobPostingDetailResponse>
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<JobPostingDetailResponse>(JobPostingDetail)
		//	};
		//}

		//public async Task<ServiceResponse<JobPostingDetailResponse>> SelectAsync(JobPostingDetailSelect Model)
		//{
		//	return new ServiceResponse<JobPostingDetailResponse>
		//	{
		//		ResponseDataSource = Mapper.Map<List<JobPostingDetailResponse>>
		//		(await UnitOfWork.JobPostingDetail.SelectAsync(x => x.IsActive == true))
		//	};
		//}

		//public async Task<ServiceResponse<JobPostingDetailResponse>> SelectSingleAsync(JobPostingDetailSelectSingle Model)
		//{
		//	return new ServiceResponse<JobPostingDetailResponse>
		//	{
		//		ResponseDataSource = Mapper.Map<List<JobPostingDetailResponse>>
		//		(await UnitOfWork.JobPostingDetail.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
		//	};
		//}
	}
}