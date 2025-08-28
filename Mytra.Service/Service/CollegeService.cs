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
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CollegeResponse>> UpdateAsync(CollegeUpdate Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CollegeResponse>> DeleteAsync(CollegeDelete Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CollegeResponse>> SelectAsync(CollegeSelect Model)
		{
			throw new NotImplementedException();
		}

		public async Task<ServiceResponse<CollegeResponse>> SelectSingleAsync(CollegeSelectSingle Model)
		{
			throw new NotImplementedException();
		}
	}
}