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

		public async Task<DataService<CandidateSkills>> DeleteAsync(CandidateSkillsDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<DataService<CandidateSkills>> InsertAsync(CandidateSkillsInsert Model)
		{
			try
			{
				Data = Mapper.Map<CandidateSkills>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<CandidateSkills>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.CandidateSkills.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<CandidateSkills>.SuccessResult(Data, "Record has been success")
					: DataService<CandidateSkills>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<CandidateSkills>.FailureResult(ex.Message, "some error");
			}
		}

		public async Task<DataService<CandidateSkills>> SelectAsync(CandidateSkillsSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<DataService<CandidateSkills>> SelectSingleAsync(CandidateSkillsSelectSingle Model)
		{
			throw new NotImplementedException();
		}

		public async Task<DataService<CandidateSkills>> UpdateAsync(CandidateSkillsUpdate Model)
		{
			try
			{
				Collection = await UnitOfWork.CandidateSkills.SelectAsync(x => x.Id == Model.Id);
				if (Collection == null)
					return DataService<CandidateSkills>.FailureResult("Kayıt bulunamadı");

				Data = Collection.SingleOrDefault()!;
				//Data = Mapper.Map(model, Data);
				Data.Name = Model.Name;
				Data.UpdateDate = DateTime.Now;

				await UnitOfWork.CandidateSkills.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return Success
					? DataService<CandidateSkills>.SuccessResult(Data, "Kayıt güncellendi")
					: DataService<CandidateSkills>.FailureResult("Kayıt güncellenemedi");
			}
			catch (Exception ex)
			{
				return DataService<CandidateSkills>.FailureResult(ex.Message, "Beklenmeyen hata oluştu");
			}
		}

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