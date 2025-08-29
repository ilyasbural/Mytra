namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class InstitutionService : IInstitutionService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<Institution> Validator;

		public InstitutionService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Institution> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<InstitutionResponse>> InsertAsync(InstitutionInsert Model)
		{
			return new ServiceResponse<InstitutionResponse>
			{
				//IsSuccess = false,
				//Message = "Not implemented",
				//Errors = new List<string> { "This method is not yet implemented." }
			};
			//return await Task.Run(() => {
			//	var response = new ServiceResponse<InstitutionResponse>();
			//	try
			//	{
			//		var entity = Mapper.Map<Institution>(Model);
			//		var validationResult = Validator.Validate(entity);
			//		if (!validationResult.IsValid)
			//		{
			//			response.IsSuccess = false;
			//			response.Message = "Validation failed";
			//			response.Errors = validationResult.Errors.Select(e => e.ErrorMessage).ToList();
			//			return response;
			//		}
			//		UnitOfWork.InstitutionRepository.Add(entity);
			//		UnitOfWork.Commit();
			//		response.Data = Mapper.Map<InstitutionResponse>(entity);
			//		response.IsSuccess = true;
			//		response.Message = "Institution inserted successfully";
			//	}
			//	catch (Exception ex)
			//	{
			//		response.IsSuccess = false;
			//		response.Message = "An error occurred while inserting the institution";
			//		response.Errors = new List<string> { ex.Message };
			//	}
			//	return response;
			//});
		}

		public async Task<ServiceResponse<InstitutionResponse>> UpdateAsync(InstitutionUpdate Model)
		{
			return new ServiceResponse<InstitutionResponse>
			{
				//IsSuccess = false,
				//Message = "Not implemented",
				//Errors = new List<string> { "This method is not yet implemented." }
			};
		}

		public async Task<ServiceResponse<InstitutionResponse>> DeleteAsync(InstitutionDelete Model)
		{
			return new ServiceResponse<InstitutionResponse>
			{
				//IsSuccess = false,
				//Message = "Not implemented",
				//Errors = new List<string> { "This method is not yet implemented." }
			};
		}

		public async Task<ServiceResponse<InstitutionResponse>> SelectAsync(InstitutionSelect Model)
		{
			return new ServiceResponse<InstitutionResponse>
			{
				//IsSuccess = false,
				//Message = "Not implemented",
				//Errors = new List<string> { "This method is not yet implemented." }
			};
		}

		public async Task<ServiceResponse<InstitutionResponse>> SelectSingleAsync(InstitutionSelectSingle Model)
		{
			return new ServiceResponse<InstitutionResponse>
			{
				//IsSuccess = false,
				//Message = "Not implemented",
				//Errors = new List<string> { "This method is not yet implemented." }
			};
		}
	}
}