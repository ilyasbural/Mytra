namespace Mytra.Service
{
	using Core;
	using Common;
	using AutoMapper;
	using FluentValidation;

	public class LanguageService : BusinessObject<Language>, ILanguageService
	{
		readonly IMapper Mapper;
		readonly IUnitOfWork UnitOfWork;
		readonly IValidator<Language> Validator;

		public LanguageService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<Language> validator)
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
			Validator = validator;
		}

		public async Task<ServiceResponse<LanguageResponse>> InsertAsync(LanguageInsert Model)
		{
			Data = Mapper.Map<Language>(Model);
			Data.Id = Guid.NewGuid();
			Data.RegisterDate = DateTime.Now;
			Data.UpdateDate = DateTime.Now;
			Data.IsActive = true;

			Validator.ValidateAndThrow<Language>(Data);
			await UnitOfWork.Language.InsertAsync(Data);
			Success = await UnitOfWork.SaveChangesAsync();

			return new ServiceResponse<LanguageResponse>
			{
				Success = Success,
				ResponseData = Mapper.Map<LanguageResponse>(Data)
			};
		}

		public async Task<ServiceResponse<LanguageResponse>> UpdateAsync(LanguageUpdate Model)
		{
			return new ServiceResponse<LanguageResponse>
			{
				//IsSuccess = true,
				//Message = "Language updated successfully",
				//Data = new LanguageResponse
				//{
				//	Id = Model.Id,
				//	Name = Model.Name,
				//	Code = Model.Code
				//}
			};
		}

		public async Task<ServiceResponse<LanguageResponse>> DeleteAsync(LanguageDelete Model)
		{
			return new ServiceResponse<LanguageResponse>
			{
				//IsSuccess = true,
				//Message = "Language deleted successfully",
				//Data = null
			};
		}

		public async Task<ServiceResponse<LanguageResponse>> SelectAsync(LanguageSelect Model)
		{
			return new ServiceResponse<LanguageResponse>
			{
				//IsSuccess = true,
				//Message = "Languages retrieved successfully",
				//Data = new List<LanguageResponse>
				//{
				//	new LanguageResponse { Id = 1, Name = "English", Code = "EN" },
				//	new LanguageResponse { Id = 2, Name = "Spanish", Code = "ES" }
				//}
			};
		}

		public async Task<ServiceResponse<LanguageResponse>> SelectSingleAsync(LanguageSelectSingle Model)
		{
			return new ServiceResponse<LanguageResponse>
			{
				//IsSuccess = true,
				//Message = "Language retrieved successfully",
				//Data = new LanguageResponse
				//{
				//	Id = Model.Id,
				//	Name = "English",
				//	Code = "EN"
				//}
			};
		}
	}
}