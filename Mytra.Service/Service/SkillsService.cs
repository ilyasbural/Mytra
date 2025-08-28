namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class SkillsService : ISkillsService
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

		public Task<ServiceResponse<SkillsResponse>> InsertAsync(SkillsInsert Model)
		{
			throw new NotImplementedException();
		}

		public Task<ServiceResponse<SkillsResponse>> UpdateAsync(SkillsUpdate Model)
		{
			throw new NotImplementedException();
		}

		public Task<ServiceResponse<SkillsResponse>> DeleteAsync(SkillsDelete Model)
		{
			throw new NotImplementedException();
		}

		public Task<ServiceResponse<SkillsResponse>> SelectAsync(SkillsSelect Model)
		{
			throw new NotImplementedException();
		}

		public Task<ServiceResponse<SkillsResponse>> SelectSingleAsync(SkillsSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}