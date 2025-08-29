namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class CollegeService : ICollegeService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<College> Validator;

		public CollegeService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<College> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<CollegeResponse>> InsertAsync(CollegeInsert Model)
		{
			return new ServiceResponse<CollegeResponse>()
			{
				//ResponseData = new CollegeResponse(),
				//ResponseDataSource = new List<CollegeResponse>(),
				//Success = 1
			};
		}

		public async Task<ServiceResponse<CollegeResponse>> UpdateAsync(CollegeUpdate Model)
		{
			return new ServiceResponse<CollegeResponse>()
			{
				//ResponseData = new CollegeResponse(),
				//ResponseDataSource = new List<CollegeResponse>(),
				//Success = 1
			};
		}

		public async Task<ServiceResponse<CollegeResponse>> DeleteAsync(CollegeDelete Model)
		{
			return new ServiceResponse<CollegeResponse>()
			{
				//ResponseData = new CollegeResponse(),
				//ResponseDataSource = new List<CollegeResponse>(),
				//Success = 1
			};
		}

		public async Task<ServiceResponse<CollegeResponse>> SelectAsync(CollegeSelect Model)
		{
			return new ServiceResponse<CollegeResponse>()
			{
				//ResponseData = new CollegeResponse(),
				//ResponseDataSource = new List<CollegeResponse>(),
				//Success = 1
			};
		}

		public async Task<ServiceResponse<CollegeResponse>> SelectSingleAsync(CollegeSelectSingle Model)
		{
			return new ServiceResponse<CollegeResponse>()
			{
				//ResponseData = new CollegeResponse(),
				//ResponseDataSource = new List<CollegeResponse>(),
				//Success = 1
			};
		}
	}
}