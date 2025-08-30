namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class InstitutionService : BusinessObject<Institution>, IInstitutionService
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
			Data = Mapper.Map<Institution>(Model);
			Data.Id = Guid.NewGuid();
			Data.RegisterDate = DateTime.Now;
			Data.UpdateDate = DateTime.Now;
			Data.IsActive = true;

			Validator.ValidateAndThrow<Institution>(Data);
			await UnitOfWork.Institution.InsertAsync(Data);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<InstitutionResponse>
			{
				Success = Success,
				ResponseData = Mapper.Map<InstitutionResponse>(Data)
			};
		}

		public async Task<ServiceResponse<InstitutionResponse>> UpdateAsync(InstitutionUpdate Model)
		{
			Collection = await UnitOfWork.Institution.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			Institution Institution = Collection.SingleOrDefault()!;
			Institution.Name = Model.Name;
			await UnitOfWork.Institution.UpdateAsync(Institution);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<InstitutionResponse>
			{
				Success = Success,
				ResponseData = Mapper.Map<InstitutionResponse>(Institution)
			};
		}

		public async Task<ServiceResponse<InstitutionResponse>> DeleteAsync(InstitutionDelete Model)
		{
			Collection = await UnitOfWork.Institution.SelectAsync(x => x.Id == Model.Id && x.IsActive == true);
			Institution Institution = Collection.SingleOrDefault()!;
			await UnitOfWork.Institution.DeleteAsync(Institution);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<InstitutionResponse>
			{
				Success = Success,
				ResponseData = Mapper.Map<InstitutionResponse>(Institution)
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