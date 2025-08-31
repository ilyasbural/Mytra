namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class SkillsService : BusinessObject<Skills>, ISkillsService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<Skills> Validator;

		public SkillsService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Skills> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<DataService<Skills>> InsertAsync(SkillsInsert Model)
		{
			try
			{
				Data = Mapper.Map<Skills>(Model);
				Data.Id = Guid.NewGuid();
				Data.RegisterDate = DateTime.Now;
				Data.UpdateDate = DateTime.Now;
				Data.IsActive = true;

				var validationResult = await Validator.ValidateAsync(Data);
				if (!validationResult.IsValid)
				{
					return DataService<Skills>.FailureResult(
						validationResult.Errors.Select(e => e.ErrorMessage).ToList(),
						"Validasyon hatası");
				}

				await UnitOfWork.Skills.InsertAsync(Data);
				var affectedRows = await UnitOfWork.SaveChangesAsync();
				var success = affectedRows > 0;

				return success
					? DataService<Skills>.SuccessResult(Data, "Record has been success")
					: DataService<Skills>.FailureResult("fail");
			}
			catch (Exception ex)
			{
				return DataService<Skills>.FailureResult(ex.Message, "some error");
			}
		}

		//public async Task<ServiceResponse<SkillsResponse>> UpdateAsync(SkillsUpdate Model)
		//{
		//	Collection = await UnitOfWork.Skills.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	Skills Skills = Collection.SingleOrDefault()!;
		//	Skills.Name = Model.Name;
		//	await UnitOfWork.Skills.UpdateAsync(Skills);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<SkillsResponse>
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<SkillsResponse>(Skills)
		//	};
		//}

		//public async Task<ServiceResponse<SkillsResponse>> DeleteAsync(SkillsDelete Model)
		//{
		//	Collection = await UnitOfWork.Skills.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
		//	Skills Skills = Collection.SingleOrDefault()!;
		//	await UnitOfWork.Skills.DeleteAsync(Skills);
		//	Success = await UnitOfWork.SaveChangesAsync();

		//	return new ServiceResponse<SkillsResponse>
		//	{
		//		Success = Success,
		//		ResponseData = Mapper.Map<SkillsResponse>(Skills)
		//	};
		//}

		//public async Task<ServiceResponse<SkillsResponse>> SelectAsync(SkillsSelect Model)
		//{
		//	return new ServiceResponse<SkillsResponse>
		//	{
		//		ResponseDataSource = Mapper.Map<List<SkillsResponse>>
		//		(await UnitOfWork.Skills.SelectAsync(x => x.IsActive == true))
		//	};
		//}

		//public async Task<ServiceResponse<SkillsResponse>> SelectSingleAsync(SkillsSelectSingle Model)
		//{
		//	return new ServiceResponse<SkillsResponse>
		//	{
		//		ResponseDataSource = Mapper.Map<List<SkillsResponse>>
		//		(await UnitOfWork.Skills.SelectAsync(x => x.Id == Model.Id && x.IsActive == true))
		//	};
		//}
	}
}