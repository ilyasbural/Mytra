namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;
	using System.Reflection.Metadata.Ecma335;

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

		public async Task<ServiceResponse<SkillsResponse>> InsertAsync(SkillsInsert Model)
		{
			return new ServiceResponse<SkillsResponse>
			{
				//IsSuccess = true,
				//Message = "Skills inserted successfully",
				//Data = new SkillsResponse
				//{
				//	SkillId = 1,
				//	SkillName = Model.SkillName,
				//	Description = Model.Description
				//}
			};
		}

		public async Task<ServiceResponse<SkillsResponse>> UpdateAsync(SkillsUpdate Model)
		{
			return new ServiceResponse<SkillsResponse>
			{
				//IsSuccess = true,
				//Message = "Skills updated successfully",
				//Data = new SkillsResponse
				//{
				//	SkillId = Model.SkillId,
				//	SkillName = Model.SkillName,
				//	Description = Model.Description
				//}
			};
		}

		public async Task<ServiceResponse<SkillsResponse>> DeleteAsync(SkillsDelete Model)
		{
			return new ServiceResponse<SkillsResponse>
			{
				//IsSuccess = true,
				//Message = "Skills deleted successfully",
				//Data = null
			};
		}

		public async Task<ServiceResponse<SkillsResponse>> SelectAsync(SkillsSelect Model)
		{
			return new ServiceResponse<SkillsResponse>
			{
				//IsSuccess = true,
				//Message = "Skills retrieved successfully",
				//Data = new SkillsResponse
				//{
				//	SkillId = 1,
				//	SkillName = "Sample Skill",
				//	Description = "This is a sample skill description"
				//}
			};
		}

		public async Task<ServiceResponse<SkillsResponse>> SelectSingleAsync(SkillsSelectSingle Model)
		{
			return new ServiceResponse<SkillsResponse>
			{
				//IsSuccess = true,
				//Message = "Skills retrieved successfully",
				//Data = new SkillsResponse
				//{
				//	SkillId = Model.SkillId,
				//	SkillName = "Sample Skill",
				//	Description = "This is a sample skill description"
				//}
			};
		}
	}
}